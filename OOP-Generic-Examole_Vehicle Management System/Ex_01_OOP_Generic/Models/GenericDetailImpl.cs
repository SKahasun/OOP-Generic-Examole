using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public class GenericDetailImpl<T> : IGenericDetail<T>
    {
        public string GetDetail<T1>(T1 obj)
        {
           if(obj is Vehicle)
            {
                Vehicle v=obj as Vehicle;
                return v.Details();
            }
            else
            {
                return "Not a Vehicle";
            }
        }
    }
}
