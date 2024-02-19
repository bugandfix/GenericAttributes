using GenericAttributes.Abstraction;
using GenericAttributes.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Infra;

public class FacultyPrinter : IPrint
{
    public void Print(object obj)
    {
        var faculty = (Faculty)obj;
        Console.WriteLine($"Faculty => Name:{faculty.Name}");
    }
}
