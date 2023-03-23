namespace ConsoleApp1.Entities;

using System.ComponentModel.DataAnnotations;

public class Chassis
{
    [Range(1, Int32.MaxValue, ErrorMessage = "Wheels number cannot be a negative number!")]
    public int WheelsNumber { get; set; }
    
    [Required]
    public int Number { get; set; }
    
    [Required]
    public int PermissibleLoad { get; set; }

    public Chassis(int wheelsNumber, int number, int permissibleLoad)
    {
        WheelsNumber = wheelsNumber;
        Number = number;
        PermissibleLoad = permissibleLoad;
    }

    public Chassis()
    {
        
    }
}