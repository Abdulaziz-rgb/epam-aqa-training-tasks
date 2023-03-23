namespace ConsoleApp1.task_5.Models;

using CustomInterfaces;

public class Bird : IFlyable
{
    private Coordinate _currentPoint;

    private double _flySpeed { get; set; } 

    public Bird(Coordinate coordinate)
    {
        _currentPoint = coordinate;
        _flySpeed = new Random().Next(0, 21);
    }

    public void FlyTo(Coordinate newPoint)
    {
        Console.WriteLine($"Flying to new point -> ({newPoint.X}, {newPoint.Y}, {newPoint.Z}");

        _currentPoint = newPoint;
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        // Distance between current point and a new point
        double distance = GetDistance(newPoint);

        // Time taken to fly to the distance
        TimeSpan flyTime = TimeSpan.FromHours(distance / _flySpeed);

        return flyTime;
    }

    private double GetDistance(Coordinate newPoint)
    {
      return Math.Sqrt(Math.Pow((_currentPoint.X - newPoint.X), 2) +
                        Math.Pow((_currentPoint.Y - newPoint.Y), 2) +
                        Math.Pow((_currentPoint.Z - newPoint.Z), 2));  
    }
}