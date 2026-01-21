using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public class VehicleDetailsImpli<T> : IVehicleDetail<T>
    {
        public string GetDetail<T1>(T1 obj) where T1 : Vehicle
        {
            return obj.Details();
        }
    }
}
