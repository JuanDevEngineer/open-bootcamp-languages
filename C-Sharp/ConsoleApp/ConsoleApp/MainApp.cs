// // Ejercicio 1
/*
    Console.Write("Enter your name: ");
    var name = Console.ReadLine() ?? string.Empty;

    Console.WriteLine("Hi your name is: " +  name);
    Console.WriteLine("La hora actual es: " + DateTime.Now.ToString("h:mm:ss tt zz"));
*/

// // Ejercicio 2
Console.Write("ingrese su nombre: ");
string? name = Console.ReadLine();

Console.Write("ingrese su apellido: ");
string? apellido = Console.ReadLine();

Console.Write("ingrese su edad: ");
int edad = Console.Read();

Console.Write("sabe programar: ");
int sabeProgramar = Console.Read();

string message = $"Bienvenido {name} {apellido} con edad {edad}, al curso de programacion, dice usted que sabe programar {Convert.ToBoolean(sabeProgramar)}";
Console.WriteLine(message);

Console.WriteLine("--------------");

// Descripcion de un coche
int puertas = 4;
int ruedas = 4;
string marca = "audi";
bool itvVigente = true;

Console.WriteLine(puertas);
Console.WriteLine(ruedas);
Console.WriteLine(marca);
Console.WriteLine(itvVigente);

Console.WriteLine("--------------");

// Descripcion de una mesa
float peso = 43.55F;
float largo = 123.25F;
string material = "aluminio";
string color = "yellow";

Console.WriteLine(peso);
Console.WriteLine(largo);
Console.WriteLine(material);
Console.WriteLine(color);

Console.WriteLine("--------------");

// Operadores
int myNumber = 65;
Console.WriteLine(myNumber >= 18);
Console.WriteLine("dos condiciones que son verdaderas: " +  (myNumber > 50 && myNumber <= 65));

bool condicion1 = myNumber == 65;
bool condicion2 = myNumber < 18;
Console.WriteLine("dos condiciones una verdadera la otra falsa: "+ condicion1 + condicion2);

Console.WriteLine("--------------");

char myChar = 'a';
Console.WriteLine(myChar == 'a');



