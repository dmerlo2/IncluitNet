// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Datos numericos

byte numeroByte = 12;
int numeroInteger = 0;
long numeroLong = 200;
double numeroDouble = 300.123;
float numeroFloat = 400;

//Datos logicos
bool datoBool = false; // 0
bool datosBool2 = true; // 1

//Datos de texto
string datoString = "Texto";

Console.WriteLine(datoString);
Console.WriteLine("dato 2");

Console.WriteLine("Ingrese valor: ");
datoString = Console.ReadLine();

Console.WriteLine(datoString);

int datoInt = Convert.ToInt32(datoString);

Console.WriteLine(datoInt);