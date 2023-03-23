namespace ConsoleApp1.task_5.CustomInterfaces;

using Models;

public interface IFlyable
{
    void FlyTo(Coordinate newPoint);
    
    TimeSpan GetFlyTime(Coordinate newPoint);
}