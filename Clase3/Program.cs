// Borra la pantalla
Console.Clear();

//Pedimos al usuario que introduzca su nombre
Console.WriteLine("Hola, Ingrese su nombre: ");

//Leemos nombre de usuario
string nombre = Console.ReadLine();

//Pedimos introduzca el apellido
string apellido = Console.ReadLine();   

//Mostrar el nombre
Console.WriteLine("Hola "+nombre);
Console.WriteLine("Este es mi segundo programa");

Console.WriteLine("Pulse una tecla para continuar");
Console.ReadKey();


Console.WriteLine("Ingrese base del rectangulo: ");
double baseRectangulo= double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese altura del rectangulo:");
double alturaRectangulo = double.Parse(Console.ReadLine());

double superficieRectangulo = baseRectangulo * alturaRectangulo;

Console.WriteLine("La superficie del restangulo es: ");
Console.WriteLine(superficieRectangulo);

bool esMayora10 = superficieRectangulo > 10;

if (esMayora10)
{
    Console.WriteLine("La superficie del restacngulo es mayor a 10");
}





