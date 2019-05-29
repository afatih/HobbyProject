using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DTO
{
   public class UserDTO
    {
        public int UserID { get; set; }
        public string TC_No { get; set; }
        public string Passport { get; set; }
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public byte? Gender { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsNew { get; set; }
        public bool IsDelete { get; set; }
        public ICollection<HobbyDTO> Hobbies { get; set; }
        public ICollection<PhoneDTO> Phones  { get; set; }


    }
}
