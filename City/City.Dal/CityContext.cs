using City.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Dal
{
    public class CityContext:DbContext
    {
        public CityContext(DbContextOptions<CityContext> db):base(db)
        {

        }
        public DbSet<Cities> Cities { get; set; }
    }
}
