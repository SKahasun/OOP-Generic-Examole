using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic.Models
{
    public class FourWheeler : Vehicle, IInteriorDesign
    {
        public FourWheeler() { }
        public FourWheeler(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, int noOfSeat, int noOfDoor): base(model, yearMake, cc, noOfGear, vehicleType)
        {
            this.NoOfSeat=noOfSeat;
            this.NoOfDoor=noOfDoor;
        }
        private List<string> inDesigns = new List<string>();

        public int NoOfSeat { get; set; }
        public int NoOfDoor { get; set; }

        public void AddInteriorDesign(params string[] design)
        {
            this.inDesigns.AddRange(design);
        }

        public override string Details()
        {
            return $"{Model}, {CC}, {YearMake},{NoOfGear}, {NoOfSeat} seats, {NoOfDoor}";
        }

        public string GetInteriorDesign()
        {
            return string.Join(", ", inDesigns);
        }
    }
}
