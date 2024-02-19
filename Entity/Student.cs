using GenericAttributes.Infra.Attributes;
using GenericAttributes.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Entity;





// Simple Attribute
//[PrintObject(typeof(StudentPrinter))]

[PrintObject<StudentPrinter>]
public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}
