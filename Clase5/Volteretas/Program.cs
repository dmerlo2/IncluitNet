// Consulte cuantas vueltas quiere dar, haga un While mientras
// la respuesta sea diferente de N cuente las vueltas y muestre
// cuantas vueltas van

Console.WriteLine("Cuantas vueltas quiere dar?");

var resp = "S";
var contador = 0;

while (resp.ToUpper() != "N")
{
    contador++;
    Console.WriteLine("Vueltas actuales " + contador);

    Console.WriteLine("Seguimos (S/N) ?");
        resp = Console.ReadLine();
    
}

//EJERCICIO2
//Ingrese cantidad de vueltas y con un While siga hasta hasta dar las vueltas ingresadas

Console.WriteLine("EJERCICIO 2");
Console.ReadKey();

Console.WriteLine("Ingrese cantidad de vueltas:");
var nInteraciones = int.Parse(Console.ReadLine());
var nContador = 0;
while (nContador < nInteraciones)
{
    nContador++;
    Console.WriteLine("Cantidad de iteraciones" + nContador);
}


//EJERCICIO3
//Ciclo FOR

Console.WriteLine("EJERCICIO 3");
Console.ReadKey();

for (var canti=0; canti<10; canti++)
{
    Console.WriteLine($"Vuelta numero {canti} de iteraciones");
}


//EJERCICIO TABLA DE MULTIPLICAR

Console.WriteLine("EJERCICIO TABLA DE MULTIPLICAR");
Console.ReadKey();

Console.WriteLine("Ingrese numero para calcular tabla de multiplicar");
int nNumero = int.Parse(Console.ReadLine());

var nValor = 0;

for (var canti=1; canti<11; canti++)
{
    nValor = nNumero * canti;
    Console.WriteLine($"Calculado: {nNumero} X {canti} = {nValor}");
}