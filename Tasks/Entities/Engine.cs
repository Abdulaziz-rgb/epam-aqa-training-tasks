namespace ConsoleApp1.Entities;

public class Engine
{
    public int Power { get; set; }
    
    public double Volume { get; set; }
    
    // Types can be of  petrol or diesel
    public string Type { get; set; }
    
    public string SerialNumber { get; set; }
}