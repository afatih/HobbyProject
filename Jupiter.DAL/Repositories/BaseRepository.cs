using Jupiter.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jupiter.DAL.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
            where T : class
    {
        private DbSet _dbset = Db.Context.Set<T>();

        public int Add(T entity)
        {
            Db.Context.Entry(entity).State = EntityState.Added;
            return Save();

        }

        public int Delete(T entity)
        {
            Db.Context.Entry(entity).State = EntityState.Deleted;
            return Save();
        }

        public T Get(int id)
        {
        //    int id = ((IQueryable<T>)_dbset).Where(x=>x)
            return (T)_dbset.Find(id);
        }

        public List<T> Get()
        {
            return ((IQueryable<T>)_dbset).ToList();
        }

        public int Save()
        {
            return Db.Context.SaveChanges();
        }

        public int Update(T entity)
        {
            Db.Context.Entry(entity).State = EntityState.Modified;
            return Save();
        }

    }
}
