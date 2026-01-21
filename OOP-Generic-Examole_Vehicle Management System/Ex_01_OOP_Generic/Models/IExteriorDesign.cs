using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public interface IExteriorDesign
    {
        void AddExteriorDesign(params string[] design);
        string GetExteriorDesign();
    }
}
