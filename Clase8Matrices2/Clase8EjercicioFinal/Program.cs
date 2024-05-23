//Clase 8 Ejercicio Final

//1)_ Crear una matriz de dos dimensiones de tipo int llamada numeros
//2)_ Determinar el tamaño de cada dimension (fila, columna) mediante valores
//          ingresados en pantalla.
//3)_ Declarar un vector de tipo double llamado promedios.
//4)_ Recorrer al matriz para su carga con elementos de tipo int
//5)_ Recorrer la matriz para mostrar cada valor de ella
//6)_ Calcular el promedio de cada columna y asignarloa  la posicion correspondiente
//          dentro del vector promedios.
//7)_ Mostrar los promedios recorriendo el vector promedios

//2) Determinar tamaño de matriz, filas y columnas
Console.WriteLine("Ingresar filas de la matriz");
int nFilas=int.Parse(Console.ReadLine());

Console.WriteLine("Ingresar columnas de la matriz");
int nColumnas=int.Parse(Console.ReadLine());    

//1) Crear matriz
int [,] numeros = new int[nFilas,nColumnas];

//3)_ Declarar vector promedios
double[] promedios = new double[nColumnas];

//4)_ Cargar matriz
for (int columna = 0; columna < nColumnas; columna++)
{
    Console.WriteLine("==============");
    Console.WriteLine($"Cargue valores de Columna {columna + 1}");
    for (int fila = 0; fila < nFilas; fila++)
    {
        Console.WriteLine($"Cargar valor de Columna: {columna + 1 }, Fila: {fila + 1} ");
        numeros[fila,columna]=int.Parse(Console.ReadLine());    

    }
}

double suma = 0;
double promedio = 0;

//Mostrar valores cargados en la matriz
for (int columna = 0; columna < nColumnas; columna++)
{
    suma = 0;
    promedio = 0;
    Console.WriteLine($"Valores de columna {columna + 1}");
    Console.WriteLine("===================");
    for(int fila = 0; fila < nFilas; fila++)
    {
       Console.WriteLine(numeros[fila, columna]);
        suma += numeros[fila, columna];
        promedio = suma / nFilas;

       ;
    }
    Console.WriteLine($"Suma de la columna {columna + 1 }: {suma}");
    Console.WriteLine($"Promedio de la columna {columna + 1 }: {promedio}");
}
