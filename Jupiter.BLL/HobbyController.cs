using Jupiter.DAL;
using Jupiter.DAL.Repositories;
using Jupiter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.BLL
{
    public class HobbyController
    {
        HobbyManagement _hm;

        HobbyRepository _hr;

        public HobbyController()
        {
            _hm = new HobbyManagement();

            _hr = new HobbyRepository();
        }

        public bool AddHobby(HobbyDTO dto)
        {
            Hobby hobby = HobbyMapping(dto);
            try
            {
                if (_hr.Add(hobby)>0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }

        public List<HobbyDTO> GetHobies()
        {
            return HobbyDTOMapping(_hr.Get());
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

        private HobbyDTO HobbyDTOMapping(Hobby hobby)
        {
            HobbyDTO hobbyDTO = new HobbyDTO();

            if (hobby!=null)
            {
                hobbyDTO.ID = hobby.ID;
                hobbyDTO.HobbyName = hobby.HobbyName;                
            }

            return hobbyDTO;
        }

        private List<HobbyDTO> HobbyDTOMapping(List<Hobby> hobbies)
        {
            List<HobbyDTO> list = new List<HobbyDTO>();
            foreach (var item in hobbies)
            {
                HobbyDTO yeni = HobbyDTOMapping(item);
                list.Add(yeni);
            }

            return list;
        }

        public List<HobbiesUsersDTO> YasKisit(List<HobbiesUsersDTO> hobbyUsers, decimal min_Yas, decimal max_Yas)
        {
            List<HobbiesUsersDTO> yeniListe = new List<HobbiesUsersDTO>();

            foreach (var item in hobbyUsers)
            {
                TimeSpan timeSpan = DateTime.Now - item.UserBirthDate.Value;
                int yas = timeSpan.Days / 365;
                if (yas>min_Yas && yas<max_Yas)

                {
                    yeniListe.Add(item);
                }
            }
            return yeniListe;
        }

        public HobbyDTO GetHobbyName(string name)
        {
            HobbyDTO hobbyDTO;
            Hobby hobby = _hr.Get(name);

            if (hobby!=null)
            {
                hobbyDTO = HobbyDTOMapping(hobby);
                hobbyDTO.IsNew = false;
            }
            else
            {
                hobbyDTO = HobbyDTOMapping(hobby);
                hobbyDTO.IsNew = true;
            }
            return hobbyDTO;
        }

      

        public List<HobbiesUsersDTO> GetHobbyUsers(int? hobbyID)
        {
            List<HobbiesUsersDTO> users = new List<HobbiesUsersDTO>();
            HobbyDTO dto = new HobbyDTO();
            dto.ID = (int)hobbyID;
            Hobby hobby = HobbyMapping(dto);
            users = _hm.GetHobbyUsers(hobbyID);
            return users;
        }

        public List<HobbyDTO> GetChildHobbies(HobbyDTO hobbyDTO)
        {
            Hobby hobby = HobbyMapping(hobbyDTO);
            return HobbyDTOMapping( _hr.GetChildHobbies(hobby));
        }

        public List<HobbyDTO> GetMainHobbies()
            
        {
            List<Hobby> hobbies = _hm.GetHobbies(null);
            return HobbyDTOMapping(hobbies);
        }

        public List<JustUserHobbiesDTO> GetUserHobbies(int UserID)
        {
            List<JustUserHobbiesDTO> kisininHobileri = new List<JustUserHobbiesDTO>();
            kisininHobileri = _hm.GetUserHobbies(UserID);
            return kisininHobileri;
             
        }

        public int DeleteUsersHobby(int userID, string hobbyName)
        {
            int? hobbyID = _hr.IsMainHobby(hobbyName);
            
            return _hm.DeleteUsersHobby(userID, hobbyName, hobbyID);
        }        

        public int HaveUserHobby(int hobbyId)
        {
            User_Hobby userHobby = _hr.HaveUserHobby(hobbyId);
            int haveHobby = -1;
            if (userHobby != null )
            {
                haveHobby = _hm.UpdateUserHobby(hobbyId);
                return haveHobby;
            }
            return haveHobby;
        }
    }
}
