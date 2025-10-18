using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;
        protected double fuelLevel;
        public Car(string brand, int year, double mileage, int doors, double maxSpeed = 180.0) : base(brand, year, mileage, maxSpeed)
        {
            this.doors = doors;
            fuelLevel = 50.0;
        }
        public override string GetInfo()
        {
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel}L";
        }
        public override void Move(double distance)
        {
            if (fuelLevel > 0)
            {
                base.Move(distance);
                fuelLevel -= distance * 0.1;
            }
            if (fuelLevel <= 0)
            {
                fuelLevel = 0;
            }
        }
        public void Refuel(double liters)
        {
            if (fuelLevel < 50)
            {
                fuelLevel += liters;
            }
            if (fuelLevel >= 50)
            {
                fuelLevel = 50;
            }
        }
    }
}
