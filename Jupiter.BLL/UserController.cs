using Jupiter.DAL;
using Jupiter.DAL.Repositories;
using Jupiter.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.BLL
{
    public class UserController
    {
        UserManagement _um;
        JupiterDBContext _db;
        HobbyController _hc;
        UserRepository _ur;

        public UserController()
        {
            _um = new UserManagement();
            _hc = new HobbyController();
            _ur = new UserRepository();
            _db = Db.Context;
        }
        
        public ArrayList AddMainHobbytoUser(HobbyDTO hobbydto, UserDTO userdto)
        {
            ArrayList arraylist = new ArrayList();
            Hobby hobby = HobbyMapping(hobbydto);
            User user = UserMapping(userdto);
            _hc.HaveUserHobby(hobby.ID);

            List<JustUserHobbiesDTO> userHobbies = _hc.GetUserHobbies(userdto.UserID);
            foreach (var item in userHobbies)
            {
                if (item.HobbyName == hobbydto.HobbyName)
                {
                    arraylist.Add(false);
                    arraylist.Add("Kişi bu hobiye zaten sahiptir");
                    return arraylist;
                }

            }

            if (_um.AddMainHobbytoUser(hobby, user) > 0)
            {
                arraylist.Add(true);
                arraylist.Add("Kayıt Başarılı");
                return arraylist;
            }
            else
            {
                arraylist.Add(false);
                arraylist.Add("Kayıt Başarısız");
                return arraylist; ;
            }
        }

        public ArrayList AddHobbytoUser(HobbyDTO hobbydto, UserDTO userdto)
        {
            ArrayList arraylist = new ArrayList();
            bool hobbyVarmi = false;
            Hobby hobby = HobbyMapping(hobbydto);
            User user = UserMapping(userdto);
            _hc.HaveUserHobby(hobby.ID);
            Hobby girilmekIstenenHobininMainHobisi = _um.GetOneMainHobby(hobby);

            List<JustUserHobbiesDTO> userHobbies = _hc.GetUserHobbies(userdto.UserID);
            foreach (var item in userHobbies)
            {
                if (item.HobbyName == girilmekIstenenHobininMainHobisi.HobbyName)
                {
                    hobbyVarmi = true;
                }

            }

       
            foreach (var item in userHobbies)
            {
                if (item.HobbyName == hobbydto.HobbyName)
                {
                    arraylist.Add(false);
                    arraylist.Add("Kişi bu hobiye zaten sahiptir");
                    return arraylist;
                }

            }

            if (hobbyVarmi == true)
            {
                if (_um.AddMainHobbytoUser(hobby, user) > 0)
                {
                    arraylist.Add(true);
                    arraylist.Add("Kayıt Başarılı");
                    return arraylist;
                }
                else
                {
                    arraylist.Add(false);
                    arraylist.Add("Kayıt başarısız");
                    return arraylist;
                }
            }
            else
            {
                if (_um.AddHobbytoUser(hobby, user) > 0)
                {
                    arraylist.Add(true);
                    arraylist.Add("Kayıt Başarılı");
                    return arraylist;
                }
                else
                {
                    arraylist.Add(false);
                    arraylist.Add("Kayıt başarısız");
                    return arraylist;
                }

            }

        }

        private Hobby HobbyMapping(HobbyDTO dto)
        {
            Hobby hobby = new Hobby()
            {
                HobbyName = dto.HobbyName,
                UpperID = dto.UpperID
            };

            return hobby;
        }

        public List<string> GetUserHobbies(UserDTO dto)
        {
            User user = UserMapping(dto);
            return _um.GetUserHobbies(user);
        }

        public int GetUser(int UserID)
        {
            int userID = _um.GetUser(UserID);
            return userID;
        }

        public UserDTO GetUserByTC(string TC)
        {

            User user = _ur.GetByTC(TC);
            UserDTO userdto;

            if (user != null)
            {

                userdto = UserMappingtoDTO(user);
                userdto.IsNew = false;
            }

            else
            {
                userdto = UserMappingtoDTO(user);
                userdto.IsNew = true;
            }


            return userdto;

        }

        public bool AddUser(UserDTO userdto)
        {
            User user = UserMapping(userdto);
            try
            {
                if (_ur.Add(user) > 0)
                {
                    userdto.UserID = user.ID;
                    return true;

                }

            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private User UserMapping(UserDTO userdto)
        {
            User user = new User();
            user.ID = userdto.UserID;
            user.TCNo = userdto.TC_No;
            user.PassaportNo = user.PassaportNo;
            user.FirstName = userdto.FirstName;

            user.LastName = userdto.LastName;
            user.Adress = userdto.Adress;

            user.Birthdate = userdto.Birthdate;
            user.Email = userdto.Email;
            user.Gender = userdto.Gender;

            foreach (var item in userdto.Phones)
            {
                Phone phone = new Phone();

                phone.PhoneNumber = item.PhoneNumber;
                user.Phones.Add(phone);
            }


            return user;
        }

        private UserDTO UserMappingtoDTO(User user)
        {
            UserDTO userdto = new UserDTO();
            userdto.Phones = new List<PhoneDTO>();
            if (user != null)
            {

                userdto.UserID = user.ID;
                userdto.FirstName = user.FirstName;
                userdto.LastName = user.LastName;
                userdto.TC_No = user.TCNo;
                userdto.Gender = user.Gender;
                userdto.Email = user.Email;
                userdto.Adress = user.Adress;
                foreach (var item in user.Phones)
                {
                    PhoneDTO phonedto = new PhoneDTO();
                    phonedto.PhoneNumber = item.PhoneNumber;
                    userdto.Phones.Add(phonedto);
                }
                
            }
            return userdto;

        }
       
        public bool UpdateUser(UserDTO userdto)
        {
            User user = UpdateUserMapping(userdto);
            try
            {
                if (_ur.Update(user)>0)
                {
                    return true;
                }
            
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        private User UpdateUserMapping(UserDTO userdto)
        {
            User user = new User();
            user.ID = userdto.UserID;
            user.TCNo = userdto.TC_No;
            user.PassaportNo = user.PassaportNo;
            user.FirstName = userdto.FirstName;

            user.LastName = userdto.LastName;
            user.Adress = userdto.Adress;

            user.Birthdate = userdto.Birthdate;
            user.Email = userdto.Email;
            user.Gender = userdto.Gender;

            foreach (var item in userdto.Phones)
            {
                Phone phone = new Phone();

                phone.PhoneNumber = item.PhoneNumber;
                user.Phones.Add(phone);
            }

            return user;
        }

    }
}
