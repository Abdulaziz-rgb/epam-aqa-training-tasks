namespace ConsoleApp1;

public class TurnTvOff : ICommand
{
    private readonly IElectronicDevice _electronicDevice;

    public TurnTvOff(IElectronicDevice electronicDevice)
    {
        _electronicDevice = electronicDevice;
    }
    public void Execute()
    {
        _electronicDevice.Off();
    }
}