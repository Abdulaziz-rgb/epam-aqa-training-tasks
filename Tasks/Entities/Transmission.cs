namespace ConsoleApp1.Entities;

public class Transmission
{
    // transmission types can be of manual or automatic
    public string Type { get; set; }
    
    public int NumberOfGears { get; set; }
    
    public string Manufacturer { get; set; }
}