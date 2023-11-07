using R504_TP01_Automobile.Core.Car;
using R504_TP01_Automobile.Core.Scooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R504_TP01_Automobile.Factories
{
    public interface IVehicleFactory
    {
        public Car CreateCar();
        public Scooter CreateScooter();
    }
}
