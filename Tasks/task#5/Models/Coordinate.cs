using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.task_5.Models;

public struct Coordinate
{
    [Range(1, Int32.MaxValue)]
    public int x;
    
    [Range(1, Int32.MaxValue)]
    public int y;
    
    [Range(1, Int32.MaxValue)]
    public int z;
}