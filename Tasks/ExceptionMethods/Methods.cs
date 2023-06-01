using ConsoleApp1.CustomExceptions;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Vehicles;

namespace ConsoleApp1.ExceptionMethods;

public static class Methods
{
    public static void RemoveAutoById(List<Vehicle> vehicles)
    {
        var id = Guid.NewGuid();
        try
        {
            var searchedAuto = vehicles.Find(x => x.Id == id);

            if (searchedAuto == null)
            {
                throw new RemoveAutoException(id);
            }

            vehicles.Remove(searchedAuto);
        }
        catch (RemoveAutoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public static void UpdateAutoById(List<Vehicle> vehicles)
    {
        var updatedCar = new PassengerCar();
        updatedCar.SetInfo( "Passenger car",
            new Engine
            {
                Power = 250,
                SerialNumber = "7uasdhgy8",
                Volume = 2.0,
                Type = "Petrol"
            }, 
            new Chassis
            {
                Number = 3,
                PermissibleLoad = 5500,
                WheelsNumber = 8,
            }, 
            new Transmission
            {
                Manufacturer = "Subaru",
                NumberOfGears = 4,
                Type = "Manual"
            } );
        var id = Guid.NewGuid();
        try
        {
            var searchedAuto = vehicles.Find(x => x.Id == id);

            if (searchedAuto == null)
            {
                throw new UpdateAutoException(id);
            }
            searchedAuto = updatedCar;
        }
        catch (UpdateAutoException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public static void GetAutoByParameter(string propertyName, string filterValue, List<Vehicle> vehicles)
    {
        try
        {
            var pi = typeof(Vehicle).GetProperty(propertyName);
            if ( pi == null)
            {
                throw new GetAutoByParameterException(propertyName);
            }
            var newAutos =  vehicles.Select(item => new {
                    value = item,
                    prop = pi.GetValue(item),
                })
                .Where(item => null == filterValue
                    ? item.prop == null
                    : item.prop != null && string.Equals(filterValue, item.prop.ToString()))
                .Select(item => item.value)
                .ToList();
            
            Console.Write(newAutos);
        }
        catch (GetAutoByParameterException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

