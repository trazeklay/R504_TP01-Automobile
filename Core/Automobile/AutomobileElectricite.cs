using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core.Automobile
{
    public class AutomobileElectricite : IAutomobile
    {
        public void AfficherCaracteristiques()
        {
            Console.WriteLine("Automobile électrique créée.");
        }
    }
}
