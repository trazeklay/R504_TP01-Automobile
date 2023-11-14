using R504_TP01_Automobile.Factories;
using R504_TP01_Automobile.Core.Scooter;
using R504_TP01_Automobile.Core.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Core
{
    public class Catalogue
    {
        public ElectricVehicleFactory electricVehicleFactory;
        public PetrolVehicleFactory petrolVehicleFactory;

        public List<PetrolCar> petrolCars { get; set; }
        public List<ElectricCar> electricCars { get; set; }

        public List<PetrolScooter> petrolScooters { get; set; }
        public List<ElectricScooter> electricScooters { get; set; }

        public Catalogue()
        {
            this.petrolCars = new List<PetrolCar>();
            this.electricCars = new List<ElectricCar>();
            this.petrolScooters = new List<PetrolScooter>();
            this.electricScooters = new List<ElectricScooter>();
        }
    }
}
