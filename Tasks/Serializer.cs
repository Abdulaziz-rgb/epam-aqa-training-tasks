﻿namespace ConsoleApp1;

using System.Xml.Serialization;
using ConsoleApp1.Entities.Vehicles;


public static class Serializer
{
    public static string ToXML(Vehicle vehicle)
    {
        using(var stringWriter = new StringWriter())
        { 
            var serializer = new XmlSerializer(vehicle.GetType());
            serializer.Serialize(stringWriter, vehicle);
            return stringWriter.ToString();
        }
    }
    
    public static void GetXmlString(List<Vehicle> vehicles)
    {
        List<string> xmlStringList = new List<string>();
        foreach (var veh in vehicles)
        {
            xmlStringList.Add(ToXML(veh));
        }

        foreach (var xml in xmlStringList)
        {
            Console.WriteLine(xml + "\n");
        }
    }
}