using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public sealed class MotorCycle:TwoWheeler
    {
        public MotorCycle()
        {
            
        }
        public MotorCycle(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, string StartingMethod, int MaximumPowerInBPH, int MaximumTorqueInNM, int Mileage, string Cooling, string FrontBrake, string RearBrake):base(model,yearMake,cc, noOfGear, vehicleType, StartingMethod, MaximumPowerInBPH, MaximumTorqueInNM, Mileage, Cooling, FrontBrake,RearBrake) 
        {
            
        }
        
    }
}
