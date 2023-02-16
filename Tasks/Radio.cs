namespace ConsoleApp1;

public class Radio : IElectronicDevice
{
    private int _volume = 0;
    public void On()
    {
        Console.WriteLine("Radio is ON");
    }

    public void Off()
    {
        Console.WriteLine("Radio is OFF");
    }

    public void VolumeUp()
    {
        _volume++;
        Console.WriteLine("Radio Volume is at " + _volume);
    }

    public void VolumeDown()
    {
        _volume--;
        Console.WriteLine("Radio Volume is at " + _volume);
    }
}