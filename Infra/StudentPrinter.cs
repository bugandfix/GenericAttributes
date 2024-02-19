using GenericAttributes.Abstraction;
using GenericAttributes.Entity;
using GenericAttributes.Infra.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Infra;


public class StudentPrinter : IPrint
{
    public void Print(object obj)
    {
        var student = (Student)obj;
        Console.WriteLine($"Student => FirstName:{student.FirstName} LastName:{student.LastName}");
    }
}
