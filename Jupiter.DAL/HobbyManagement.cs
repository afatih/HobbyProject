using Jupiter.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL
{

    public class HobbyManagement
    {
        JupiterDBContext _db;
        public HobbyManagement()
        {
            _db = Db.Context;
        }

        public int AddHobby(Hobby hobby)
        {
            _db.Hobbies.Add(hobby);
            _db.Entry(hobby).State = EntityState.Added;
            return _db.SaveChanges();
        }

        public List<Hobby> GetHobbies(int? id)
        {
            var sonuc = _db.Hobbies.Where(h => h.UpperID == id).ToList();
            return sonuc;
        }

        public List<HobbiesUsersDTO> GetHobbiesUsers(Hobby hobby)
        {
            var sorgu = _db.Hobbies
              .Join(_db.User_Hobby, h => h.ID, uh => uh.HobbyID,
              (h, uh) => new { h, uh })
              .Join(_db.Users, j => j.uh.UserID, u => u.ID,
              (j, u) => new { j, u })
              .Join(_db.Phones, j => j.u.ID, p => p.UserID,
              (j, p) => new { j, p })
              .Where(j => j.j.j.h.HobbyName == hobby.HobbyName)
              .Select(j => new HobbiesUsersDTO
              {
                  UserID = j.j.u.ID,
                  FirstName = j.j.u.FirstName,
                  Phone = j.p.PhoneNumber
              }
              ).ToList();
            return sorgu;
        }

        public List<HobbiesUsersDTO> GetHobbyUsers(int? hobbyID)
        {
            //User tablosu ile Phone tablosu left joinlendi
            var sorgu = (from uh in _db.User_Hobby
                         where uh.HobbyID == (int)(hobbyID)
                         join u in _db.Users on uh.UserID equals u.ID
                         join p in _db.Phones
                         on u.ID equals p.UserID into table
                         from t in table.DefaultIfEmpty()
                             //where
                             //orderby
                         select new HobbiesUsersDTO
                         {
                             UserID = u.ID,
                             UserBirthDate = u.Birthdate,
                             FirstName = u.FirstName,
                             Phone = t.PhoneNumber

                         });
                         
            return sorgu.ToList();
        }

        public Hobby GetHobyName(string name)
        {
            return _db.Hobbies.Where(h => h.HobbyName == name).FirstOrDefault();
        }

        public List<Hobby> GetAllHobies()
        {
            return _db.Hobbies.ToList();
        }

        public List<Hobby> GetChildHobbies(Hobby hobby)
        {
            return _db.Hobbies.Where(x => x.UpperID == hobby.UpperID).ToList();
        }

        public List<JustUserHobbiesDTO> GetUserHobbies(int UserID)
        {
            var userHobbies = _db.Users
                .Join(_db.User_Hobby, u => u.ID, uh => uh.UserID,
                (u, uh) => new { u.ID, uh.HobbyID, uh.IsDelete })
                    .Where(uh=>uh.IsDelete==false)
                .Join(_db.Hobbies, j => j.HobbyID, h => h.ID,
                (j, h) => new JustUserHobbiesDTO { UserID = j.ID, HobbyName = h.HobbyName })
                .Where(j => j.UserID == UserID).ToList();
                

            return userHobbies;

        }

        public int DeleteUsersHobby(int userID,string hobbyName,int? upperID)
        {
            List<User_Hobby> us = _db.Hobbies.Where(h => h.HobbyName == hobbyName || h.UpperID==upperID)
                .Join(_db.User_Hobby, h => h.ID, uh => uh.HobbyID,
                (h, uh) => uh)
                .Where(uh=>uh.UserID==userID).ToList();
            foreach (var item in us)
            {
                _db.Entry(item).State = EntityState.Deleted;
            }
            
            return _db.SaveChanges();
        }       

        public User_Hobby HaveUserHobby(int hobbyId)
        {
            return _db.User_Hobby.Where(uh => uh.HobbyID == hobbyId).FirstOrDefault();
        }

        public int UpdateUserHobby(int hobbyId)
        {
            var hobby = _db.User_Hobby.Where(uh => uh.HobbyID == hobbyId).FirstOrDefault();
            hobby.IsDelete = false;
            return _db.SaveChanges();
        }

        public int IsMainHobby(string hobbyName)
        {
            var sorgu = _db.Hobbies.Where(h => h.HobbyName == hobbyName && h.UpperID == null).Select(h=>h.ID).FirstOrDefault();
            return sorgu;        
        }        
    }

}
