using R504_TP01_Automobile.Core.Automobile;
using R504_TP01_Automobile.Core.Scooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Factories
{
    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public IAutomobile CreeAutomobile()
        {
            return new AutomobileElectricite();
        }

        public IScooter CreeScooter()
        {
            return new ScooterElectricite();
        }
    }
}
