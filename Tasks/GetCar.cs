using ConsoleApp1.Commands;

namespace ConsoleApp1;

public class GetCar
{
    public static ICar GetAllCars()
    {
        return new Car();
    }
}