using Jupiter.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL.Repositories
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public User GetByTC(string TC)
        {
            User user = Db.Context.Users.Where(u => u.TCNo == TC).FirstOrDefault();

            if (user != null)
            {
                return user;
            }

            return null;
        }
    }
}
