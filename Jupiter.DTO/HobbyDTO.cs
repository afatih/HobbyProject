using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DTO
{
    public class HobbyDTO
    {
        public int ID { get; set; }
        public string HobbyName { get; set; }
        public int? UpperID { get; set; }
        public bool IsNew { get; set; }
    }
}
