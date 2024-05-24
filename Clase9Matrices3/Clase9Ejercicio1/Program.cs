
//Ingresar tamaño del arreglo
Console.WriteLine("Ingrese tamaño del arreglo");
var tamañoArreglo = int.Parse(Console.ReadLine());

//Definir arreglo
int[] miVector = new int[tamañoArreglo];

Random aleatorio = new Random();

//llena el vector con valores random
for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = aleatorio.Next(100);
}

//mostrar valores generados
for (int i = 0; i < miVector.Length; i++)
{
    Console.WriteLine($"Posicion: {i + 1}   valor generado: {miVector[i]}");
}

//modificar valor en posicion ingresada
Console.WriteLine("Ingrese posicion del arreglo a modificar:");
int npos=int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese valor nuevo:");
int nNuevoValor=int.Parse(Console.ReadLine());


Boolean bFinalizar=false;   

     while(bFinalizar==false)
    {
        if (npos>miVector.Length)
        {
            Console.WriteLine("Posicion mayor que el tamaño del vector, intente nuevamente");
            //modificar valor en posicion ingresada
            Console.WriteLine("Ingrese posicion del arreglo a modificar:");
            npos = int.Parse(Console.ReadLine());
    }
        else
        {
            if (nNuevoValor < 1)
            {
                Console.WriteLine("el numero ingreasado para la nueva posicion debe ser mayor a 0");
                Console.WriteLine("Ingrese valor nuevo:");
                nNuevoValor = int.Parse(Console.ReadLine());

        }
        else
            {
                Console.ReadKey();
                miVector[npos-1] = nNuevoValor;
                bFinalizar = true;
            }
        }

    }


//mostrar valores generados
for (int i = 0; i < miVector.Length; i++)
{
    Console.WriteLine($"Posicion: {i + 1}   valor generado: {miVector[i]}");
}

