// version 10 de c sharp
Console.Write("Escribe tu nombre: ");
var name = Console.ReadLine() ?? string.Empty;

Console.WriteLine("Hola tu nombre es: " +  name);
Console.WriteLine("La hora actual es: " + DateTime.Now.ToString());