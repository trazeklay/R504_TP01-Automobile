using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core.Automobile
{
    public class AutomobileEssence : IAutomobile
    {

        public string Model { get; set; } = "Aston Martin Vantage";
        public int FuelCapacity { get; set; } = 100;
        public double Consommation { get; set; } = 10.2;

        public AutomobileEssence(string model, int fuelCapacity, double consommation)
        {
            Model = model;
            FuelCapacity = fuelCapacity;
            Consommation = consommation;
        }

        public AutomobileEssence()
        {
            
        }

        public void AfficherCaracteristiques()
        {
            Console.WriteLine($"Automobile essence créée: Modèle - {Model}, Capacité du réservoir - {FuelCapacity} litres, Consommation - {Consommation} L/100kms.");
        }
    }
}
