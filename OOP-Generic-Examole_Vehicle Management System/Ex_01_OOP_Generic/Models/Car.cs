using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public sealed class Car:FourWheeler
    {
        public Car()
        {
            
        }
        public Car(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, int noOfSeat, int noOfDoor):base(model, yearMake, cc, noOfGear, vehicleType, noOfSeat, noOfDoor) 
        {
            
        }
    }
}
