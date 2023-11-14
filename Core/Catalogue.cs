using R504_TP01_Automobile.Core.Automobile;
using R504_TP01_Automobile.Core.Scooter;
using R504_TP01_Automobile.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core
{
    public class Catalogue
    {
        private IAutomobile automobile;
        private IScooter scooter;

        public Catalogue(IFabriqueVehicule fabrique)
        {
            automobile = fabrique.CreeAutomobile();
            scooter = fabrique.CreeScooter();
        }

        public void AfficherCaracteristiques()
        {
            automobile.AfficherCaracteristiques();
            scooter.AfficherCaracteristiques();
        }
    }
}
