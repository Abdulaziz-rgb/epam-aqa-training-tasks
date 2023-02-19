namespace ConsoleApp1.Commands;

public class GetAveragePriceType : Command
{

    private readonly ICar _car;

    private string _search;

    public GetAveragePriceType(ICar car, string search)
    {
        _car = car;
        _search = search;
    }

    public void Execute()
    {
        _car.AveragePriceType(_search);
    }
}