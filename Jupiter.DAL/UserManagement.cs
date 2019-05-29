using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL
{

    public class UserManagement
    {
        JupiterDBContext _db;
        int eklenenTelefonSayisi;
        public UserManagement()
        {
            _db = Db.Context;
            eklenenTelefonSayisi = 0;
        }

        public int AddUser(User user)
        {
            _db.Entry(user).State = System.Data.Entity.EntityState.Added;
            return _db.SaveChanges();
        }

        public int AddHobbytoUser(Hobby hobby, User user)
        {
            var sorgu = _db.Users.Where(x => x.ID == user.ID).FirstOrDefault();
            User_Hobby uh = new User_Hobby();
            uh.HobbyID = _db.Hobbies.Where(x => x.HobbyName == hobby.HobbyName).Select(x => x.ID).FirstOrDefault();
            uh.UserID = user.ID;
            uh.IsDelete = false;
            _db.Entry(uh).State = System.Data.Entity.EntityState.Added;
            _db.SaveChanges();

            var sorguUpperID = (from h in _db.Hobbies
                                where h.HobbyName == hobby.HobbyName
                                select h.UpperID).FirstOrDefault();

            if (sorguUpperID != null)
            {
                User_Hobby uh2 = new User_Hobby();
                uh2.HobbyID = _db.Hobbies.Where(x => x.ID == sorguUpperID).Select(x => x.ID).FirstOrDefault();
                uh2.UserID = user.ID;
                uh2.IsDelete = false;
                _db.Entry(uh2).State = System.Data.Entity.EntityState.Added;

            }

            return _db.SaveChanges();

        }

        public int AddMainHobbytoUser(Hobby hobby, User user)
        {
            var sorgu = _db.Users.Where(x => x.ID == user.ID).FirstOrDefault();
            User_Hobby uh = new User_Hobby();
            uh.HobbyID = _db.Hobbies.Where(x => x.HobbyName == hobby.HobbyName).Select(x => x.ID).FirstOrDefault();
            uh.UserID = user.ID;
            uh.IsDelete = false;
            _db.Entry(uh).State = System.Data.Entity.EntityState.Added;
            return _db.SaveChanges();
        }
        ArrayList arrayList = new ArrayList();

        public User GetUserByTC(string TC)
        {
            User user = (from u in _db.Users
                         where u.TCNo == TC
                         select u).FirstOrDefault();
            

            return user;


        }

        public List<string> GetUserHobbies(User user)
        {
            var kisininHobileri = _db.Users
                .Join(_db.User_Hobby, u => u.ID, uh => uh.UserID,
                (u, uh) => new { u, uh })
                .Join(_db.Hobbies, j => j.uh.HobbyID, h => h.ID,
                (j, h) => new { j, h })
                .Where(j => j.j.u.ID == user.ID)
                .Select(j => j.h.HobbyName).ToList();

            return kisininHobileri;
        }

        public Hobby GetOneMainHobby(Hobby hobby)
        {
            var hobbyninUstIDsi = _db.Hobbies.Where(x => x.HobbyName == hobby.HobbyName).Select(x => x.UpperID).FirstOrDefault();

            var ustHobiIsmi = _db.Hobbies.Where(x => x.ID == hobbyninUstIDsi).Select(x => x.HobbyName).FirstOrDefault();
            Hobby hobbyYeni = new Hobby();
            hobbyYeni.HobbyName = ustHobiIsmi;
            return hobbyYeni;


        }


        public int GetUser(int UserID)
        {
            return _db.Users.Where(u => u.ID== UserID).Select(u=>u.ID).FirstOrDefault();
        }

        public int UpdateUser(User user)
        {
            //_db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            var Phone = _db.Phones.Where(p => p.UserID == user.ID).ToList();
            foreach (var item in Phone)
            {
                _db.Phones.Remove(item);
            }
            try
            {
                var Userx= _db.Users.Where(w => w.ID == user.ID).FirstOrDefault();

                
                

                Userx.Email = user.Email;
                Userx.Adress = user.Adress;


                Userx.Phones = user.Phones;
                return _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
