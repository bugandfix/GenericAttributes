using GenericAttributes.Abstraction;
using GenericAttributes.Entity;
using GenericAttributes.Infra;
using GenericAttributes.Infra.Attributes;


namespace GenericAttributes.Wrapper;

public class PrintObject
{
    #region SwitchCaseWay
    //public void PrintObjectToConsole(object obj)
    //{
    //    IPrint? consolePrinter = obj switch
    //    {
    //        Student => new StudentPrinter(),
    //        Location => new LocationPrinter(),
    //        _ => null
    //    };

    //    if (consolePrinter is not null)
    //    {
    //        consolePrinter.Print(obj);
    //    }
    //    else
    //    {
    //        Console.WriteLine(obj);
    //    }
    //}
    #endregion

    #region WithAttribute
    //public void PrintObjectToConsole(object obj)
    //{
    //    var wasPrinted = false;
    //    var attributes = obj.GetType().GetCustomAttributes(
    //                       typeof(PrintObjectAttribute), inherit: false);

    //    if (attributes.Length == 1
    //        && attributes[0] is PrintObjectAttribute consoleWriterAttribute)
    //    {
    //        var printObjectType = consoleWriterAttribute.PrintObjectType;
    //        var objectPrinter = Activator.CreateInstance(printObjectType)
    //                              as IPrint;
    //        if (objectPrinter is not null)
    //        {
    //            objectPrinter.Print(obj);
    //            wasPrinted = true;
    //        }
    //    }

    //    if (!wasPrinted)
    //    {
    //        Console.WriteLine(obj);
    //    }
    //}
    #endregion


    #region WithGenericAttribute
    public void PrintObjectToConsole(object obj)
    {
        var wasPrinted = false;
        var attributes = obj.GetType().GetCustomAttributes(
                           typeof(PrintObjectAttribute<>), inherit: false);

        if (attributes.Length == 1
            && attributes[0].GetType()
                 .GetGenericTypeDefinition() == typeof(PrintObjectAttribute<>))
        {
            var printObjectType = attributes[0].GetType().GetGenericArguments()[0];
            var objectPrinter = Activator.CreateInstance(printObjectType)
                as IPrint;
            if (objectPrinter is not null)
            {
                objectPrinter.Print(obj);
                wasPrinted = true;
            }
        }

        if (!wasPrinted)
        {
            Console.WriteLine(obj);
        }
    }
    #endregion
}
