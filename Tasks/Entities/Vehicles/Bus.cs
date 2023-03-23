namespace ConsoleApp1.Entities.Vehicles;

using Enums;

public class Bus : Vehicle
{
    public TypesEnum Type = TypesEnum.Bus;
    public Bus( string name, Engine engine, Chassis chassis, Transmission transmission) 
        : base(name,engine, chassis, transmission) { }

    public Bus()
    {
    }

    public override void DisplayInfo()
    {
        Console.Write($@"
        Displaying {Name} properties....
        Engine info... 
        Power - {Engine.Power}> 
        Engine Type: {Engine.Type}
        Engine Volume: {Engine.Volume}
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