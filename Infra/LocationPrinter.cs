using GenericAttributes.Abstraction;
using GenericAttributes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Infra;

public class LocationPrinter : IPrint
{
    public void Print(object obj)
    {
        var location = (Location)obj;
        Console.WriteLine($"Location => City:{location.City}");
    }
}
