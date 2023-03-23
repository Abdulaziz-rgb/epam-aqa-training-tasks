using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1.Entities;

public class Chassis
{
    [Required, Range(1, Int32.MaxValue, ErrorMessage = "Wheels number cannot be a negative number!")]
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
}