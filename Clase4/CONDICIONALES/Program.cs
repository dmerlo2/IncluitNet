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
