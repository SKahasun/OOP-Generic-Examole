using Ex_01_OOP_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01_OOP_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorCycle m1 = new MotorCycle("R15V5",2024,160,6,VehicleType.Personal,"Self+kick",250,22000,45,"Air coller","Disk","ABS");
            m1.AddExteriorDesign("VIP Horn", "3-part Handle","LED Fog light");
            GenericDetailImpl<MotorCycle> gd = new GenericDetailImpl<MotorCycle>();
            Console.WriteLine(gd.GetDetail<MotorCycle>(m1));
            Console.WriteLine(m1.GetExteriorDesign());
            Console.WriteLine();


            Car c1 = new Car("Land Cruiser", 2017, 1500, 6, VehicleType.Family, 5, 5);
            c1.AddInteriorDesign("GPS", "Auto Drive", "Music System");
            VehicleDetailsImpli<Car> cd = new VehicleDetailsImpli<Car>();
            Console.WriteLine(cd.GetDetail<Car>(c1));
            Console.WriteLine(c1.GetInteriorDesign());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}


    public enum VehicleType
    {
        Personal=1,Family,Sports,Racing
    }


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


    public interface IInteriorDesign
    {
        void AddInteriorDesign(params string[] design);
        string GetInteriorDesign();
    }


    public interface IExteriorDesign
    {
        void AddExteriorDesign(params string[] design);
        string GetExteriorDesign();
    }


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



    public interface IGenericDetail<T>
    {
        string GetDetail<T>(T obj);
    }


    public interface IVehicleDetail<T>
    {
        string GetDetail<T>(T obj) where T : Vehicle;
    }


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



    public class VehicleDetailsImpli<T> : IVehicleDetail<T>
    {
        public string GetDetail<T1>(T1 obj) where T1 : Vehicle
        {
            return obj.Details();
        }
    }



    public sealed class Car:FourWheeler
    {
        public Car()
        {
            
        }
        public Car(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, int noOfSeat, int noOfDoor):base(model, yearMake, cc, noOfGear, vehicleType, noOfSeat, noOfDoor) 
        {
            
        }
    }


    public sealed class MotorCycle:TwoWheeler
    {
        public MotorCycle()
        {
            
        }
        public MotorCycle(string model, int yearMake, int cc, int noOfGear, VehicleType vehicleType, string StartingMethod, int MaximumPowerInBPH, int MaximumTorqueInNM, int Mileage, string Cooling, string FrontBrake, string RearBrake):base(model,yearMake,cc, noOfGear, vehicleType, StartingMethod, MaximumPowerInBPH, MaximumTorqueInNM, Mileage, Cooling, FrontBrake,RearBrake) 
        {
            
        }
        
    }



            \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            MotorCycle m1 = new MotorCycle("R15V5",2024,160,6,VehicleType.Personal,"Self+kick",250,22000,45,"Air coller","Disk","ABS");
            m1.AddExteriorDesign("VIP Horn", "3-part Handle","LED Fog light");
            GenericDetailImpl<MotorCycle> gd = new GenericDetailImpl<MotorCycle>();
            Console.WriteLine(gd.GetDetail<MotorCycle>(m1));
            Console.WriteLine(m1.GetExteriorDesign());
            Console.WriteLine();


            Car c1 = new Car("Land Cruiser", 2017, 1500, 6, VehicleType.Family, 5, 5);
            c1.AddInteriorDesign("GPS", "Auto Drive", "Music System");
            VehicleDetailsImpli<Car> cd = new VehicleDetailsImpli<Car>();
            Console.WriteLine(cd.GetDetail<Car>(c1));
            Console.WriteLine(c1.GetInteriorDesign());
            Console.WriteLine();
            Console.ReadKey();