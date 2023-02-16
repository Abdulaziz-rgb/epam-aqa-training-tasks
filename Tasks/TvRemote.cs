namespace ConsoleApp1;

public class TvRemote
{
    public static IElectronicDevice getDevice()
    {
        return new Television();
    }
    
}