using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core.Scooter
{
    public class ScooterElectricite : IScooter
    {

        public string Model { get; set; } = "Oskour";
        public int BatteryCapacity { get; set; } = 35;
        public int MaxSpeed { get; set; } = 50;

        public ScooterElectricite(string model, int batteryCapacity, int maxSpeed)
        {
            Model = model;
            BatteryCapacity = batteryCapacity;
            MaxSpeed = maxSpeed;
        }

        public ScooterElectricite()
        {
            
        }

        public void AfficherCaracteristiques()
        {
            Console.WriteLine($"Scooter électrique créé: Modèle - {Model}, Capacité de batterie - {BatteryCapacity} kWh, Vitesse maximale - {MaxSpeed} km/h.");
        }
    }
}
