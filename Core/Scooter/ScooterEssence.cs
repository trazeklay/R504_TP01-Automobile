using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core.Scooter
{
    public class ScooterEssence : IScooter
    {

        public string Model { get; set; } = "AAH";
        public int FuelCapacity { get; set; } = 40;
        public double Consommation { get; set; } = 4.3;

        public ScooterEssence(string model, int fuelCapacity, double consommation)
        {
            Model = model;
            FuelCapacity = fuelCapacity;
            Consommation = consommation;
        }

        public ScooterEssence()
        {
            
        }

        public void AfficherCaracteristiques()
        {
            Console.WriteLine($"Scooter essence créé: Modèle - {Model}, Capacité du réservoir - {FuelCapacity} litres, Consommation - {Consommation} L/100kms.");
        }
    }
}
