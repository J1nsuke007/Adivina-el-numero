Random numeroAleatorio = new Random();

int numeroCualquiera = numeroAleatorio.Next(0, 100);
int numeroIntentos = 0;

while (numeroCualquiera <= 100)
{
    Console.WriteLine("Digite el numero para saber si acerto el numero cualquiera: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > numeroCualquiera)
    {
        Console.WriteLine("Su numero es mayor al numero cualquiera");
        numeroIntentos++;
    }else if (numero < numeroCualquiera)
    {
        Console.WriteLine("Su numero es menor al numero cualquiera");
        numeroIntentos++;
    }
    else
    {
        Console.WriteLine("Felicitaciones, has acertado el numero");
        break;
    }
}

Console.WriteLine($"Numero de intentos {numeroIntentos}");
