using R504_TP01_Automobile.Core.Car;
using R504_TP01_Automobile.Core.Scooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Factories
{
    public abstract class PetrolVehicleFactory : IVehicleFactory
    {
        public Car CreateCar()
        {
            return new PetrolCar();
        }

        public Scooter CreateScooter()
        {
            return new PetrolScooter();
        }
    }
}
