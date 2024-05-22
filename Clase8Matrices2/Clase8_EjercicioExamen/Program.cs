//Ejercicio vectores Clase8
//Ingresar cantidad de alumnos
//Ingresar por teclado nota de cada uno
//Mostrar cada una de las notas

Console.WriteLine("Ingrese cantidad de alumnos: ");
int nCantidadAlumnos =  int.Parse(Console.ReadLine());

int[] notas = new int[nCantidadAlumnos];

for (int i = 0; i < nCantidadAlumnos; i++)
{
    Console.WriteLine($"Ingrese nota de alumno {i + 1}");
    notas[i]= int.Parse(Console.ReadLine());
}

//Muestra notas ingresadas
Console.WriteLine("Notas Ingresadas");
Console.WriteLine("----- ----------");
for(int i = 0;i < nCantidadAlumnos;i++)
{
    Console.WriteLine($"Nota del alumno {i + 1} es {notas[i]}");
}