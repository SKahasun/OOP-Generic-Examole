using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
            
        }
        public Vehicle(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType)
        {
            Model = model;
            YearMake = yearMake;
            CC = cc;
            NoOfGear = noOfGear;
            VehicleType = vehicleType;
        }
        public string Model { get; set; }
        public int YearMake { get; set; }
        public int CC { get; set; }
        public int NoOfGear { get; set; }
        public VehicleType VehicleType { get; set; }
        public abstract string Details();
    }

}
