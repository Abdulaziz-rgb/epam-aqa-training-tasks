namespace ConsoleApp1.Entities.Vehicles;

using Enums;

public class Scooter : Vehicle
{
    public TypesEnum Type = TypesEnum.Scooter;
    public Scooter(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
    { }

    public override void DisplayInfo()
    {
        Console.Write($@"
        Displaying {Name} properties....
        Engine info... 
        Power - {Engine.Power}> 
        Engine Type: {Engine.Type}
        Engine Volume: {Engine.Volume}
        Engine Serial Number: {Engine.SerialNumber},
        Transmission Details:
        Transmission Manufacturer: {Transmission.Manufacturer}
        Transmission Type: {Transmission.Type}
        Transmission Number Of Gears: {Transmission.NumberOfGears}");
    }
}