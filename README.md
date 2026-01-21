# Vehicle Management System

A C# console application demonstrating Object-Oriented Programming (OOP) principles with generic implementations for managing Car and Motorcycle information.

## 📋 Features

- **Vehicle Information Management**
  - Car details: Model, Year, Seats, Gears, Doors, Engine CC, Interior Design, Vehicle Type
  - Motorcycle details: Model, Year, Gears, Starting Method, Engine CC, Power, Torque, Mileage, Cooling, Brakes, Exterior Design, Vehicle Type

- **OOP Principles Implementation**
  - Inheritance hierarchy
  - Abstract classes and sealed classes
  - Interface implementation
  - Generic programming with and without constraints
  - Encapsulation and polymorphism

## 🏗️ Architecture

### Class Hierarchy

```
Vehicle (Abstract)
├── TwoWheeler (implements IExteriorDesign)
│   └── MotorCycle (Sealed)
└── FourWheeler (implements IInteriorDesign)
    └── Car (Sealed)
```

### Key Components

#### Enums
- **VehicleType**: Personal, Family, Sports, Racing

#### Abstract Classes
- **Vehicle**: Base class for all vehicles (cannot be instantiated)

#### Sealed Classes
- **Car**: Final implementation for four-wheelers (cannot be inherited)
- **MotorCycle**: Final implementation for two-wheelers (cannot be inherited)

#### Interfaces
- **IExteriorDesign**: Manages exterior design features (implemented by TwoWheeler)
- **IInteriorDesign**: Manages interior design features (implemented by FourWheeler)
- **IGenericDetail\<T\>**: Generic interface without constraints
- **IVehicleDetail\<T\>**: Generic interface with Vehicle constraint

#### Generic Implementations
- **GenericDetailImpl\<T\>**: Generic implementation using runtime type checking
- **VehicleDetailsImpli\<T\>**: Generic implementation with compile-time constraint

## 🚀 Getting Started

### Prerequisites
- .NET Framework 4.8 or higher
- Visual Studio 2019 or later (recommended)

### Installation

1. Clone the repository
```bash
https://github.com/SKahasun/OOP-Generic-Examole
```

2. Open the solution in Visual Studio
```bash
cd vehicle-management-system
start Ex_01_OOP_Generic.sln
```

3. Build and run the project
   - Press `F5` or click "Start" in Visual Studio

## 💻 Usage Example

```csharp
// Create a Motorcycle
MotorCycle m1 = new MotorCycle(
    "R15V5", 2024, 160, 6, VehicleType.Personal,
    "Self+kick", 250, 22000, 45,
    "Air cooler", "Disk", "ABS"
);

// Add exterior design features
m1.AddExteriorDesign("VIP Horn", "3-part Handle", "LED Fog light");

// Display details using generic implementation
GenericDetailImpl<MotorCycle> gd = new GenericDetailImpl<MotorCycle>();
Console.WriteLine(gd.GetDetail<MotorCycle>(m1));
Console.WriteLine(m1.GetExteriorDesign());

// Create a Car
Car c1 = new Car(
    "Land Cruiser", 2017, 1500, 6,
    VehicleType.Family, 5, 5
);

// Add interior design features
c1.AddInteriorDesign("GPS", "Auto Drive", "Music System");

// Display details using constrained generic implementation
VehicleDetailsImpli<Car> cd = new VehicleDetailsImpli<Car>();
Console.WriteLine(cd.GetDetail<Car>(c1));
Console.WriteLine(c1.GetInteriorDesign());
```

## 📊 Sample Output

```
R15V5, 160, 2024, 45KMPL, Self+kick, 6, Air cooler, Disk, ABS, Personal, 250, 22000
VIP Horn, 3-part Handle, LED Fog light

Land Cruiser, 1500, 2017, 6, 5 seats, 5
GPS, Auto Drive, Music System
```

## 🎯 OOP Principles Demonstrated

1. **Abstraction**: Vehicle as abstract base class
2. **Inheritance**: Multi-level inheritance hierarchy
3. **Encapsulation**: Private fields with public properties
4. **Polymorphism**: Override of `Details()` method
5. **Interface Segregation**: Separate interfaces for interior/exterior designs
6. **Generics**: Both constrained and unconstrained generic implementations
7. **Sealed Classes**: Preventing further inheritance for Car and MotorCycle

## 📝 Design Patterns

- **Template Method Pattern**: Abstract `Details()` method in Vehicle class
- **Strategy Pattern**: Different design implementations through interfaces
- **Generic Programming**: Type-safe implementations with compile-time and runtime checks

## 🔧 Technical Details

### Properties

**Vehicle (Base)**
- Model, YearMake, CC, NoOfGear, VehicleType

**TwoWheeler (Additional)**
- StartingMethod, MaximumPowerInBPH, MaximumTorqueInNM, Mileage, Cooling, FrontBrake, RearBrake

**FourWheeler (Additional)**
- NoOfSeat, NoOfDoor

### Methods

- `AddExteriorDesign(params string[] design)`: Add unlimited exterior features
- `AddInteriorDesign(params string[] design)`: Add unlimited interior features
- `GetExteriorDesign()`: Retrieve all exterior designs
- `GetInteriorDesign()`: Retrieve all interior designs
- `Details()`: Abstract method for displaying vehicle information

## 📄 License

This project is created for educational purposes demonstrating OOP and Generic programming in C#.

## 👤 Author

Your Name - [Sheikh Ahasunul Islam](https://github.com/SKahasun)

## 🙏 Acknowledgments

- Created as part of OOP and Generic programming coursework
- Demonstrates practical implementation of C# advanced features

---

**Note**: This is a console application designed for learning purposes. Feel free to extend and modify according to your requirements.
