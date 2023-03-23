namespace ConsoleApp1.task_5.Models;

using CustomInterfaces;

public class Airplane : IFlyable
{
    private Coordinate _currentPoint;
    private double _flySpeed;

    public Airplane(Coordinate currentPoint)
    {
        _currentPoint = currentPoint;
        _flySpeed = 200;   
    }
    
    public void FlyTo(Coordinate newPoint)
    {
        // Calculating distance between two points
        double distance = GetDistance(newPoint);
        
        // increase speed by 10 km/h every 10 km
        double additionalSpeed = (distance / 10) * 10;
        _flySpeed += additionalSpeed;

        Console.WriteLine($"Flying from ({_currentPoint.X}, {_currentPoint.Y}, {_currentPoint.Z}) to ({newPoint.X}, {newPoint.Y}, {newPoint.Z}) at a speed of {Math.Round(_flySpeed,2)} km/h.");
        _currentPoint = newPoint;
    }

    public TimeSpan GetFlyTime(Coordinate newPoint)
    {
        double distance = Math.Sqrt(Math.Pow(newPoint.X - _currentPoint.X, 2) + Math.Pow(newPoint.Y - _currentPoint.Y, 2) + Math.Pow(newPoint.Z - _currentPoint.Z, 2));
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