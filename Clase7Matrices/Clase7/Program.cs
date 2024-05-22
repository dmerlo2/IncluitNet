//Crear matriz Cars

string[] Cars = { "Ford", "Fiat", "BMW", "Toyota" };

int [] numeros = new int[5];

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese valor posicion {i}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

//Mostrar valores cargados en vector numeros
Console.WriteLine("Numeros Ingresados");

int nSuma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
    nSuma = nSuma + numeros[i];
}

Console.WriteLine($"Suma de numeros ingresados {nSuma}");







