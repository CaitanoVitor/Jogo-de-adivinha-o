using System.Security.Cryptography;

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool jodoDeveContinuar = true;


while (jodoDeveContinuar == true)
{
    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("JOGO DE ADVINHAÇÃO");
    Console.WriteLine("-----------------------------");


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
    Console.WriteLine("Deseja continuar? S/N: ");
    string opcaoContinuar = Console.ReadLine();


    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jodoDeveContinuar = false; 
    }
}
