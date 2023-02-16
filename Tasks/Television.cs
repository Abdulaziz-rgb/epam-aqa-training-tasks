namespace ConsoleApp1;

public class Television : IElectronicDevice
{
    private int _volume = 0;
    public void On()
    {
        Console.WriteLine("TV is ON");
    }

    public void Off()
    {
        Console.WriteLine("TV is OFF");
    }

    public void VolumeUp()
    {
        _volume++;
        Console.WriteLine("TV Volume is at " + _volume);
    }

    public void VolumeDown()
    {
        _volume--;
        Console.WriteLine("TV Volume is at " + _volume);
    }
}