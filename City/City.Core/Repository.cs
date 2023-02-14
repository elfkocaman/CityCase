using City.Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Core
{
    public class Repository<T>:IRepository<T> where T : class
    {
        CityContext _db;
        public Repository(CityContext db)
        {
            _db= db;
        }

        public bool Add(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(int Id)
        {
            try
            {
                Set().Remove(Find(Id));
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public T Find(int Id)
        {
            return Set().Find(Id);
            
        }

        public List<T> List()
        {
            return Set().ToList();
            
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
            
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
