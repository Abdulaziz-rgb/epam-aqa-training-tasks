namespace ConsoleApp1.task_5.Models;

using CustomInterfaces;

public class Drone : IFlyable
{
    private Coordinate _currentPoint { get; }

    private double _flySpeed;

    public Drone(Coordinate currentPoint)
    {
        _currentPoint = currentPoint;
        _flySpeed = 20;
    }

    public void FlyTo(Coordinate newPoint)
    {
        double distance = GetDistance(newPoint);

        if (distance > 1000)
        {
            Console.WriteLine("The drone cannot fly such a long distance.");
            return;
        }
        TimeSpan time = GetFlyTime(newPoint);

        Console.WriteLine(
            $"Drone is flying from ({_currentPoint.X}, {_currentPoint.Y}, {_currentPoint.Z}) to ({newPoint.X}, {newPoint.Y}, {newPoint.Z} in {time} hours");
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPoint.X, 2) + 
                                    Math.Pow(newPoint.Y - _currentPoint.Y, 2) + 
                                    Math.Pow(newPoint.Z - _currentPoint.Z, 2));
        
        TimeSpan time = TimeSpan.FromHours(distance / _flySpeed);
        
        return time;
    }

    private double GetDistance(Coordinate newPoint)
    {
        return Math.Sqrt(Math.Pow(newPoint.X - _currentPoint.X, 2) + 
                         Math.Pow(newPoint.Y - _currentPoint.Y, 2) + 
                         Math.Pow(newPoint.Z - _currentPoint.Z, 2));
    }
}