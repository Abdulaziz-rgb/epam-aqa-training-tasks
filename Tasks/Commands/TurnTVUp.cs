namespace ConsoleApp1;

public class TurnTVUp : ICommand
{
    private IElectronicDevice _electronicDevice;

    public TurnTVUp(IElectronicDevice electronicDevice)
    {
        _electronicDevice = electronicDevice;
    }
    public void Execute()
    {
        _electronicDevice.VolumeUp();
    }
}