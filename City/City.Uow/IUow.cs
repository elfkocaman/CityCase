using City.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City.Uow
{
    public interface IUow
    {
        ICitiesRep _cityRep { get; }

        void Commit();
    }
}
