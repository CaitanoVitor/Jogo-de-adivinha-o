using System.Security.Cryptography;

bool jodoDeveContinuar = true;


while (jodoDeveContinuar == true)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine("JOGO DE ADVINHAÇÃO");
    Console.WriteLine("-----------------------------");

    int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

    Console.WriteLine();
    Console.Write("DIGITE UM NÚEMRO: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("O numero aleatorio foi: " + numeroAleatorio);

    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("Parabéns você acertou! O número aleatorio era exatamente " + numeroAleatorio);
    }

    else if (numeroDigitado < numeroAleatorio)
    {
        Console.WriteLine("O numero digitado foi menor que o numero secreto");
    }

    else
    {
        Console.WriteLine("O número digitado foi maior que o numero secreto");
    }


    Console.WriteLine();
    Console.WriteLine("Digite ENTER para o jogo continuar...");
    Console.ReadLine();
}

