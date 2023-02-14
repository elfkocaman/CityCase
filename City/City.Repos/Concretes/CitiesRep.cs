using City.Core;
using City.Dal;
using City.Entity;
using City.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Repos.Concretes
{
    public class CitiesRep<T>:Repository<Cities>,ICitiesRep
    {
        public CitiesRep(CityContext db):base(db) 
        {

        }

    }
}
