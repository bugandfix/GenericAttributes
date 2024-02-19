using GenericAttributes.Infra.Attributes;
using GenericAttributes.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Entity;






// Simple Attribute
//[PrintObject(typeof(LocationPrinter))]


[PrintObject<LocationPrinter>]
public class Location
{
    public string? City { get; set; }
}
