using ConsoleApp1.Commands;
using ConsoleApp1.Model;

namespace ConsoleApp1;

public class Car : ICar
{
    private readonly List<CarModel> _cars = CarBase.GetAllCars();

    public void CountTypes()
    {
        var brands =  _cars.Select(x => x.Brand).Distinct().Count();
        Console.WriteLine(brands);
    }

    public void CountAll()
    {
        var all =  _cars.Select(x => x.Quantity).Sum();
        Console.WriteLine(all);
    }

    public void AveragePrice()
    {
        var averagePrice =  _cars.Select(x => x.Price).Sum() / _cars.Count;
        Console.WriteLine(averagePrice);
    }

    public void AveragePriceType(string search)
    {
        search = char.ToUpper(search[0]) + search.Substring(1);
        var brands = _cars.Select(x => x.Brand).ToList();

        if (brands.Contains(search))
        {
            var results = _cars.Where(x => x.Brand == search).ToList();
            var averagePriceType = results.Select(x => x.Price).Sum() / results.Count();
            Console.WriteLine(averagePriceType);
        }
        else
        {
            Console.WriteLine($"Brand with {search} name is not present!");
        }
    }
}