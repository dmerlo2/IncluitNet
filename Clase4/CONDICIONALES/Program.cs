Console.WriteLine("Ingrese se Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su equipo e futbol: ");
string equipo = Console.ReadLine();

bool condicion = edad < 18 && equipo == "RIVER";

if (condicion)
{
    Console.WriteLine("Usted es menor ed ead");
}
else
{
    Console.WriteLine("Usted es mayor de edad");
}

//Ejercicio2
Console.WriteLine("Ejercicio 2");
Console.WriteLine("Ingrese numero 1: ");
double numero1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Numero2;  ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("1 - Suma");
Console.WriteLine("2 - Resta");
Console.WriteLine("3 - Multiplicacion");
Console.WriteLine("4 - Division");

Console.WriteLine("Ingrese Operacion, del 1 al 4:");
string operacion =Console.ReadLine();

double resultado = 0;

switch (operacion)
{
    case "1":
        resultado = numero1 + numero2;
        break;
    case "2":
        resultado = numero1 - numero2;
        break;
    case "3":
        resultado = numero1 * numero2;
        break;
    case "4" when numero2 !=0:
        resultado = numero1 + numero2;
        break;
    default:
        Console.WriteLine("Ingrese numero valido");
        break;
}

Console.WriteLine("El resultado es: "+ resultado);


