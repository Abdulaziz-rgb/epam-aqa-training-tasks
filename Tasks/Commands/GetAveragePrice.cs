namespace ConsoleApp1.Commands;

public class GetAveragePrice : Command
{

    private readonly ICar _car;

    public GetAveragePrice(ICar car)
    {
        _car = car;
    }

    public void Execute()
    {
        _car.AveragePrice();
    }
}