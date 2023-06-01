namespace ConsoleApp1.Commands;

public class GetCountTypes : Command
{
    private readonly ICar _car;

    public GetCountTypes(ICar car)
    {
        _car = car;
    }

    public void Execute()
    {
        _car.CountTypes();
    }
}