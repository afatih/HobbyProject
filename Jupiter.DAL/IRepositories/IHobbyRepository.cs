using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL.IRepositories
{
    interface IHobbyRepository: IBaseRepository<Hobby>
    {
        List<Hobby> GetChildHobbies(Hobby hobby);
        User_Hobby HaveUserHobby(int hobbyID);
        int IsMainHobby(string hobbyName);


    }
}
