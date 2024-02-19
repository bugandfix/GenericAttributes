using GenericAttributes.Entity;
using GenericAttributes.Wrapper;





Student student = new() { FirstName = "Ali", LastName = "Kolahdoozan" };
Location location = new() { City = "Malaysia" };
Faculty faculty = new() { Name = "IT" };


(new PrintObject()).PrintObjectToConsole(student);
(new PrintObject()).PrintObjectToConsole(location);
(new PrintObject()).PrintObjectToConsole(faculty);


Console.ReadLine();