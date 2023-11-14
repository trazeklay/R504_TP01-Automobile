using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;

namespace R504_TP01_Automobile.Core.Automobile
{
    public class AutomobileElectricite : IAutomobile
    {
        public string Model { get; set; } = "Tesla Model 3 Plaid";
        public int BatteryCapacity { get; set; } = 140;
        public int Range { get; set; } = 500;

        public AutomobileElectricite(string model, int batteryCapacity, int range)
        {
            Model = model;
            BatteryCapacity = batteryCapacity;
            Range = range;
        }

        public AutomobileElectricite()
        {
            
        }

        public void AfficherCaracteristiques()
        {
            Console.WriteLine($"Automobile électrique créée: Modèle - {Model}, Capacité de batterie - {BatteryCapacity} kWh, Autonomie - {Range} kms.");
        }
    }
}
