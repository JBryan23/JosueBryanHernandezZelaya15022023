// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EJERCICIOJBHZ15022023.Entidades;
using EJERCICIOJBHZ15022023.Negocio;

DATA dATA = new DATA();
ClsDataPalabras clsDataPalabras = new ClsDataPalabras();
Console.WriteLine("===============================");
Console.WriteLine("Bienvenido Usuario inteligente");
Console.WriteLine("===============================");

Console.WriteLine(@"Acontinuacion las palabras que ingrese
se contaran cada caracteres incluyendo los espacios.
mas informacion sobre los caracteres consulte https://es.wikipedia.org/wiki/Cadena_de_caracteres

Porfavor ingrese ENTER o Intro para continuar ");
Console.WriteLine("");
Console.ReadLine();
Console.WriteLine("Porfavor ingrese la palabra o frase que desee");

 dATA.infodatos = Console.ReadLine();
Console.WriteLine("");
 Console.WriteLine($"La palabra o frase que ingreso contiene: {clsDataPalabras.evaluacion (dATA)} caracteres");

