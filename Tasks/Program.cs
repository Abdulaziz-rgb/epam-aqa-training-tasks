using ConsoleApp1;
using ConsoleApp1.ExceptionMethods;

var vehicles = DataGenerator.CreateData();

Methods.RemoveAutoById(vehicles);
Methods.UpdateAutoById(vehicles);
Methods.GetAutoByParameter("Name", "25" ,vehicles);