using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.task_5.Models;

public struct Coordinate
{
    [Range(0, Int32.MaxValue)]
    public int X;
    
    [Range(0, Int32.MaxValue)]
    public int Y;
    
    [Range(0, Int32.MaxValue)]
    public int Z;

    public Coordinate(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}