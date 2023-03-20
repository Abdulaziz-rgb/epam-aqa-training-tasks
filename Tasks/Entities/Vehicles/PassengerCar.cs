namespace ConsoleApp1.Entities.Vehicles;

using Enums;

public class PassengerCar : Vehicle
{
    public TypesEnum Type = TypesEnum.PassengerCar;
    public PassengerCar(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
    {
    }

    public override void DisplayInfo()
    {
        Console.Write($@"
        Displaying {Name} properties....
        Engine info... 
        Engine Serial Number: {Engine.SerialNumber},
        Chassis Details:
        Chassis Number: {Chassis.Number}
        Chassis Permissible Load: {Chassis.PermissibleLoad}
        Chassis Wheels Number: {Chassis.WheelsNumber},
        Transmission Details:
        Transmission Manufacturer: {Transmission.Manufacturer}
        Transmission Type: {Transmission.Type}
        Transmission Number Of Gears: {Transmission.NumberOfGears}");
    }
}