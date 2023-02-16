namespace ConsoleApp1.task_5.Models;

using ConsoleApp1.task_5.CustomInterfaces;

public class Airplane : IFlyable
{
    public Coordinate CurrentPosition { get; set; }
    
    public void FlyTo()
    {
        throw new NotImplementedException();
    }

    public void GetFlyTime()
    {
        throw new NotImplementedException();
    }
}