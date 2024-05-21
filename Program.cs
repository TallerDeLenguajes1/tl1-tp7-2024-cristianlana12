using System.Globalization;
using GestionEmpleados;

Empleado NewEmpledo = new Empleado();

Console.WriteLine("###### Gestion de Empleados ######");
Console.WriteLine("Ingresar el nombre: ");
NewEmpledo.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese el apellido: ");
NewEmpledo.Apellido = Console.ReadLine();

Console.WriteLine("Ingrese fecha de nacimiento: ");
DateTime.TryParse(Console.ReadLine(), out NewEmpledo.FechaNacimiento.Day);
Console.WriteLine("/");
int.TryParse(Console.ReadLine(), out int mes);
Console.WriteLine("/");
int.TryParse(Console.ReadLine(), out int anio);



