using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R504_TP01_Automobile.Core.Automobile;
using R504_TP01_Automobile.Core.Scooter;

namespace R504_TP01_Automobile.Factories
{
    public interface IFabriqueVehicule
    {
        IAutomobile CreeAutomobile();
        IScooter CreeScooter();
    }
}
