//1.	Escribe un programa que:
//1) Pida 10 números al usuario.
//2) Obtener la suma de todos los números ingresados.
//3) Obtener cual es el mayor de todos los números.
//4) Obtener cual es el menor de todos los números.
//5) Obtener el promedio de todos los números.
//6) Mostrar todos los números ingresados por pantalla.
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

//Define vector
int[] numeros3 = new int[10];

//Cargar 10 numeros ingresandolos
Console.WriteLine("Cargar 10 numeros");
for (int i = 0; i < numeros3.Length; i++)
{
   Console.WriteLine($"Ingrese numero de posicion {i + 1}");
    numeros3[i] = int.Parse(Console.ReadLine());
}

int nSuma = 0;
int nMayor = 0;
int nMenor=1000000000;
double nPromedio = 0;
double nLongitud = 0;
nLongitud = numeros3.Length;

Console.WriteLine("Mostrar numeros ingresados");

for (int i = 0; i < numeros3.Length; i++)
{
    Console.WriteLine(numeros3[i]);
    nSuma=nSuma+numeros3[i];

    if (numeros3[i] > nMayor) 
    {
        nMayor = numeros3[i];
    }
    if (numeros3[i] < nMenor)
    {
        nMenor = numeros3[i];
    }
}

nPromedio = nSuma / nLongitud;

Console.WriteLine($"Suma de numeros ingresados: { nSuma}");
Console.WriteLine($"El promedio es: { nPromedio}");
Console.WriteLine($"El mayor es {nMayor}");
Console.WriteLine($"El menor es {nMenor}");