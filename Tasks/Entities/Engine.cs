namespace ConsoleApp1.Entities;

using System.ComponentModel.DataAnnotations;

public class Engine
{
    [Required]
    public int Power { get; set; }
    
    [Required]
    public double Volume { get; set; }
    
    // Types can be of  petrol or diesel
    [Required]
    public string Type { get; set; }
    
    [Required]
    [StringLength(7, ErrorMessage = "Serial number must consist of 7 values!")]
    public string SerialNumber { get; set; }

    public Engine(int power, double volume, string type, string serialNumber)
    {
        Power = power;
        Volume = volume;
        Type = type;
        SerialNumber = serialNumber;
    }

    public Engine()
    {
        
    }
}