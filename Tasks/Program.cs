using ConsoleApp1;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Vehicles;

var passengerCar = new PassengerCar( "Passenger car",
    new Engine (200,1.5, "diesel","8uthg7e"),
    new Chassis(2,2,4000),
    new Transmission("Hyundai", 5, "automatic"));


var bus = new Bus( "Bus",
    new Engine (500, 1.8,"petrol", "c2daqt5"),
    new Chassis(8,3,3000),
    new Transmission("Toyota", 5,"manual"));


var truck = new Truck("Truck",
    new Engine(800, 4.0, "diesel", "5ht73hs"),
    new Chassis(2,4, 6000),
    new Transmission ( "Man",5,"manual"));


var scooter = new Scooter("Scooter",
    new Engine(100, 1.0, "petrol", "7gh5hu4"),
    new Chassis(2, 0, 70),
    new Transmission ("BMW",3,"manual"));


var vehicles = new List<Vehicle>() { passengerCar, bus, scooter, truck };

Console.WriteLine("\nAll information about all vehicles an engine capacity of which is more than 1.5 liters"); 
var vehiclesWithEngineCapacity = vehicles
    .Where(vehicle => vehicle.Engine.Volume > 1.5)
    .ToList();
Serializer.GetXmlString(vehiclesWithEngineCapacity);


Console.WriteLine("\nEngine type, serial number and power rating for all buses and trucks");
var vehiclesOfBussesAndTrucks = vehicles
    .Where(vehicle => vehicle.Name == "Bus" || vehicle.Name == "Truck")
    .ToList();
Serializer.GetXmlString(vehiclesOfBussesAndTrucks);


Console.WriteLine("\nAll information about all vehicles, grouped by transmission type"); 
var vehiclesGroupedByTransmissionType = vehicles
    .Where(vehicle => vehicle.Transmission.Type == "Manual")
    .ToList();
Serializer.GetXmlString(vehiclesGroupedByTransmissionType);