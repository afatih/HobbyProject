using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL.IRepositories
{
    interface IBaseRepository<T>
        where T : class
    {
        T Get(int id);
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        int Save();
      
    }
}
