using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities;

public class Transmission
{
    // transmission types can be of manual or automatic

    [Required]
    public string Manufacturer { get; set; }
    
    [Range(3,6, ErrorMessage = "Invalid value for gears number")]
    public int NumberOfGears { get; set; }
    
    [Required]
    public string Type { get; set; }
    
    public Transmission(string manufacturer, int numberOfGears, string type)
    {
        Manufacturer = manufacturer;
        NumberOfGears = numberOfGears;
        Type = type;
    }
}