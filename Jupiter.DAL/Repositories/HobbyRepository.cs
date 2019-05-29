using Jupiter.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL.Repositories
{
    public class HobbyRepository : BaseRepository<Hobby>, IHobbyRepository
    {
        public Hobby Get(string name)
        {
            return Db.Context.Hobbies.Where(h => h.HobbyName == name).FirstOrDefault();
        }
   
        public List<Hobby> GetChildHobbies(Hobby hobby)
        {
           return Db.Context.Hobbies.Where(x => x.UpperID == hobby.UpperID).ToList();
        }

        public User_Hobby HaveUserHobby(int hobbyID)
        {
            return Db.Context.User_Hobby.Where(uh => uh.HobbyID == hobbyID).FirstOrDefault();

        }

        public int IsMainHobby(string hobbyName)
        {

            return Db.Context.Hobbies.Where(h => h.HobbyName == hobbyName && h.UpperID == null).Select(h => h.ID).FirstOrDefault();
        }
    }
}
