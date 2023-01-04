namespace ConsoleApp1.Entities.Vehicles;

public class Truck : Vehicle
{
    public Truck(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
    { }
}