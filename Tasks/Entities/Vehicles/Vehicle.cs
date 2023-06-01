namespace ConsoleApp1.Entities.Vehicles;

public abstract class Vehicle
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }

    public Vehicle()
    {
    }
    
    public void SetInfo(string name,Engine engine, Chassis chassis, Transmission transmission)
    {
        Id = Guid.NewGuid();
        Name = name;
        Engine = engine;
        Chassis = chassis;
        Transmission = transmission;
    }

    public void DisplayInfo()
    {
        Console.WriteLine(
            @"
-----------
Id: {0}
Name: {1},
Engine Details:
Engine Power: {2} 
Engine Type: {3}
Engine Volume: {4}
Engine Serial Number: {5},
Chassis Details:
Chassis Number: {6}
Chassis Permissible Load: {7}
Chassis Wheels Number: {8},
Transmission Details:
Transmission Manufacturer: {9}
Transmission Type: {10}
Transmission Number Of Gears: {11}
",Id, Name, Engine.Power, Engine.Type, Engine.Volume, Engine.SerialNumber,
            Chassis.Number, Chassis.PermissibleLoad, Chassis.WheelsNumber, Transmission.Manufacturer,
            Transmission.Type, Transmission.NumberOfGears);
    }
}