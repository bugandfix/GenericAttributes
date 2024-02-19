using GenericAttributes.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes.Infra.Attributes;

#region SimpleAttribute
//[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
//public class PrintObjectAttribute : Attribute
//{
//    public PrintObjectAttribute(Type printObjectType)
//    {
//        PrintObjectType = printObjectType;
//    }

//    public Type PrintObjectType { get; }
//}
#endregion

#region GenericAttribute
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public class PrintObjectAttribute<T> : Attribute where T : IPrint { }
#endregion
