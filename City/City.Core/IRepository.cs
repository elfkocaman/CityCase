using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Core
{
    public interface IRepository<T> where T : class
    {
        public List<T> List();
        public T Find(int Id);
        public bool Update(T entity);
        public bool Delete(int Id);
        public bool Add(T entity);
        public DbSet<T> Set();


    }
}
