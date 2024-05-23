//Clase 8 MATRICES Ejercicio NOTAS

//Ejercicio_ Ingresar cantidad de alumnos, ingresar cantidad de notas por alumno,
//recorrer cada alumno e ir cargando sus notas.
//Luego mostrar cada alumno y sus notas por pantalla.

Console.WriteLine("Cargue Notas de Alumno");

int nCantiAlumnos = 0;
int nCantiNotas = 0;

//Ingresar cantidad de alumnos
Console.WriteLine("Ingrese cantidad de alumnos:");
nCantiAlumnos = int.Parse(Console.ReadLine());

//Ingresar cantidad de notas por alumno
Console.WriteLine("Ingrese cantidad de notas por alumno:");
nCantiNotas = int.Parse(Console.ReadLine());

//Definir matriz

int[,] notas = new int[nCantiNotas, nCantiAlumnos];

//extraer cantidad de filas maximas de la matriz
int LengthFilas = notas.GetUpperBound(0) + 1;

//extraer cantidad de columnas
int lengthColumnas = notas.GetUpperBound(1) + 1;

//Recorremos columnas
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine($"Recorremos notas el alumno {columna + 1}: ");

    //recorre filas
    for (int fila = 0; fila < LengthFilas; fila++)
    {
        Console.WriteLine($"Ingrese nota: {fila + 1} del alumno: {columna + 1}");
        notas[fila, columna] = int.Parse(Console.ReadLine());
    }

}

//recorremos alumnos para mostrar notas
Console.WriteLine("Mostramos Notas de Alumnos");
Console.WriteLine("--------------------------");

for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();
    Console.WriteLine("===========================");
    Console.WriteLine();
    Console.WriteLine($"Notas del alumno {columna +  1}: ");

    for (int fila = 0; fila < LengthFilas; fila++)
    {
        Console.Write($"La nota en posicion {fila + 1}: es ");
        Console.WriteLine(notas [fila,columna]);
    }
}


