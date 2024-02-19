using GenericAttributes.Infra;
using GenericAttributes.Infra.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Entity;






// Simple Attribute
//[PrintObject(typeof(FacultyPrinter))]


[PrintObject<FacultyPrinter>]
public class Faculty
{
    public string? Name { get; set; }
}
