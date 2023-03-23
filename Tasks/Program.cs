using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Vehicles;

var passengerCar = new PassengerCar(
        "Passenger car",
        new Engine (200,1.5, "diesel","8uthg7e"),
        new Chassis(4,2,4000),
        new Transmission("Hyundai", 5, "automatic"));

var bus = new Bus(
    "Bus",
    new Engine (500, 1.8,"petrol", "c2daqt5"),
    new Chassis(8,3,3000),
    new Transmission("Toyota", 5,"manual"));

var truck = new Truck(
    "Truck",
    new Engine(800, 4.0, "diesel", "5ht73hs"),
    new Chassis(2,4, 6000),
    new Transmission ( "Man",5,"manual"));

var scooter = new Scooter(
    "Scooter",
    new Engine(100, 1.0, "petrol", "7gh5hu4"),
    new Chassis(2, 0, 70),
    new Transmission ("BMW",3,"manual"));

var vehicles = new List<Vehicle>() { passengerCar, bus, scooter, truck };
foreach (var vehicle in vehicles)
{
    vehicle.DisplayInfo();
}