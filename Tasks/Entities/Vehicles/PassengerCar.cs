namespace ConsoleApp1.Entities.Vehicles;

public class PassengerCar : Vehicle
{
    public PassengerCar(string name, Engine engine, Chassis chassis, Transmission transmission) : base(name, engine, chassis, transmission)
    {
    }
}