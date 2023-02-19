namespace ConsoleApp1.Commands;

public class GetCountAll : Command
{
    private readonly ICar _car;

    public GetCountAll(ICar car)
    {
        _car = car;
    }

    public void Execute()
    {
        _car.CountAll();
    }
}