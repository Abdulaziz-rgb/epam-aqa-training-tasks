namespace ConsoleApp1.Entities.Vehicles;

public abstract class Vehicle
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    
    public Vehicle( string name, Engine engine, Chassis chassis, Transmission transmission)
    {
        Id = Guid.NewGuid();
        Name = name;
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }


    public virtual void DisplayInfo()
    {
        Console.WriteLine(
            $@"
Base virtual method called....
-----Vehicle Info------
Id: {Id}
Name: {Name},
Engine Details:
Engine Power: {Engine.Power} 
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