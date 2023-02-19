using ConsoleApp1.Model;

namespace ConsoleApp1;

public class CarBase
{
    private readonly List<CarModel> _carModels;

    private static CarBase _instance = null;

    private  CarBase()
    {
        _carModels = new List<CarModel>
        {
            new() { Brand = "Toyota", Model = "S20", Price = 45000, Quantity = 1 },
            new() { Brand = "Subaru", Model = "DX7", Price = 37000, Quantity = 1 },
            new() { Brand = "Mercedes Benz", Model = "GLX", Price = 75000, Quantity = 1 },
            new() { Brand = "Hyundai", Model = "M57", Price = 30000, Quantity = 1 },
        };
    }

    public static List<CarModel> GetAllCars()
    {
        if (_instance == null)
        {
            _instance = new CarBase();
        }
        return _instance._carModels;
    }
}