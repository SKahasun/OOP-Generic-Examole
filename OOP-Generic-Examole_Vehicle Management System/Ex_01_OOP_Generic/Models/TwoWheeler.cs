using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public class TwoWheeler : Vehicle, IExteriorDesign
    {
        private  List<string> exDesigns=new List<string>();
        public TwoWheeler() { }
        public TwoWheeler(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, string StartingMethod, int MaximumPowerInBPH, int MaximumTorqueInNM, int Mileage, string Cooling, string FrontBrake, string RearBrake):base(model,yearMake,cc,noOfGear,vehicleType)
        {
            this.StartingMethod = StartingMethod;
            this.MaximumPowerInBPH = MaximumPowerInBPH;
            this.MaximumTorqueInNM= MaximumTorqueInNM;
            this.Mileage = Mileage;
            this.Cooling = Cooling;
            this.FrontBrake = FrontBrake;
            this.RearBrake = RearBrake;
        }
        public string StartingMethod { get; set; }
        public int MaximumPowerInBPH { get; set; }
        public int MaximumTorqueInNM { get; set; }
        public int Mileage { get; set; }
        public string Cooling { get; set; }
        public string FrontBrake { get; set; }
        public string RearBrake { get; set; }


        public void AddExteriorDesign(params string[] design)
        {
            exDesigns.AddRange(design);
        }

        public override string Details()
        {
            return $"{Model}, {CC}, {YearMake}, {Mileage}KMPL, {StartingMethod}, {NoOfGear}, {Cooling}, {FrontBrake}, {RearBrake}, {VehicleType}, {MaximumPowerInBPH}, {MaximumTorqueInNM}";
        }

        public string GetExteriorDesign()
        {
            return string.Join(", ", exDesigns);
        }
    }
}
