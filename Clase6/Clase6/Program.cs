int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);

int nVueltas = 1;

Console.WriteLine("Ingrese numero: ");
int numeroUsuario = int.Parse(Console.ReadLine());

while (numeroSecreto != numeroUsuario)
{
    nVueltas++;
    if (numeroUsuario > numeroSecreto)
    {
        Console.WriteLine($"Numero ingresado {numeroUsuario} es mayor a numero secreto");
        Console.WriteLine("Ingrese nuevamente un numero");
        numeroUsuario=int.Parse(Console.ReadLine());        
    }
    if (numeroUsuario < numeroSecreto)
    {
        Console.WriteLine($"Numero ingresado {numeroUsuario} es menor a numero secreto");
        Console.WriteLine("Ingrese nuevamente un numero");
        numeroUsuario = int.Parse(Console.ReadLine());
    }
    if (numeroUsuario == numeroSecreto){
        Console.WriteLine($"Felicitaciones, has adivinado el numero secreto que era: {numeroSecreto} ");
        Console.WriteLine($"Lo has logrado en {nVueltas} vueltas");
    }

}
