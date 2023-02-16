namespace ConsoleApp1;

public class TurnTvOn : ICommand
{
    private readonly IElectronicDevice _electronicDevice;

    public TurnTvOn(IElectronicDevice electronicDevice)
    {
        _electronicDevice = electronicDevice;
    }
    public void Execute()
    {
        _electronicDevice.On();
    }
}