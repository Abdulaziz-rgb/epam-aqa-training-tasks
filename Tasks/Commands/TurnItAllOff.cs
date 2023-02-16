namespace ConsoleApp1;

public class TurnItAllOff : ICommand
{
    private readonly List<IElectronicDevice> _electronicDevices;

    public TurnItAllOff(List<IElectronicDevice> electronicDevices)
    {
        _electronicDevices = electronicDevices;
    }

    public void Execute()
    {
        foreach (var device in _electronicDevices)
        {
            device.Off();
        }
    }
}