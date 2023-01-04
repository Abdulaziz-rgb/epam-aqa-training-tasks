namespace ConsoleApp1.Entities.Vehicles;

public class Bus : Vehicle
{
    public Bus( string name, Engine engine, Chassis chassis, Transmission transmission) 
        : base(name,engine, chassis, transmission) { }
}