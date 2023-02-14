using City.Dal;
using City.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Uow
{
    public class Uow:IUow
    {
        CityContext _db;
        public Uow(CityContext db, ICitiesRep cityRep)
        {
            _db= db;
            _cityRep= cityRep;
            
        }

        public ICitiesRep _cityRep { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
