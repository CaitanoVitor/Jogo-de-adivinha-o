using System.Security.Cryptography;


bool jodoDeveContinuar = true;


while (jodoDeveContinuar == true)
{

    Console.Clear();
    Console.WriteLine("-----------------------------");
    Console.WriteLine("JOGO DE ADVINHAÇÃO");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Escolha um nivel de Dificuldade ");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("1 - Fácil (10 tentativas) ");
    Console.WriteLine("2 - Médio (5 tentativas) ");
    Console.WriteLine("3 - Difício (3 tentativas) ");
    Console.WriteLine("-----------------------------");

    Console.Write("Digite sua escolha: ");
    string dificuldadeEscolhida = Console.ReadLine();

    int numeroAleatorio;
    int tentativasMaximas;

    switch (dificuldadeEscolhida)
    {
        case "1":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);
            tentativasMaximas = 10;
            break;
        case "2":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 51);
            tentativasMaximas = 5;
            break;

        case "3":
            numeroAleatorio = RandomNumberGenerator.GetInt32(1, 101);
            tentativasMaximas = 3;
            break;

        default:
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Digite uma opção válida ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Digite ENTER para continuar... ");
            Console.ReadLine();
            continue;

    }


    int pontuacao = 1000;

    int[] numerosDigitados = new int[tentativasMaximas];
    int contadorNumerosDigitados = 0;


    //enquanto a tentativa atual for menos que qrd de tentativas 

    for (int tentativaAtual = 1; tentativaAtual <= tentativasMaximas; tentativaAtual++)
    {

        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("JOGO DE ADVINHAÇÃO");
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Tentativa {tentativaAtual} de {tentativasMaximas}");
        Console.WriteLine("-----------------------------");

        Console.Write("DIGITE UM NÚEMRO: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());


        bool numeroEstaRepetido = false;

        for (int indiceAtual = 0; indiceAtual < numerosDigitados.Length; indiceAtual++)
        {
            if (numerosDigitados[indiceAtual] == numeroDigitado)
            {
                numeroEstaRepetido = true;
                break;
            }
        }

        if (numeroEstaRepetido == true)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("VOCÊ JÁ DIGITOU ESSE NÚMERO, TENTE NOVAMENTE... ");
            Console.WriteLine("-----------------------------");

            Console.Write("Digite ENTER para continuar... ");
            Console.ReadLine();

            tentativaAtual--;
            continue;
        }


        //guardar numeros
        if (contadorNumerosDigitados < numerosDigitados.Length)
        {
            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
            contadorNumerosDigitados++;

        }
        else
        {
            numerosDigitados = new int[tentativasMaximas];
            contadorNumerosDigitados = 0;

            numerosDigitados[contadorNumerosDigitados] = numeroDigitado;
            contadorNumerosDigitados++;


        }

        if (numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("Parabéns você acertou! O número aleatorio era exatamente " + numeroAleatorio);
            break;
        }

        else if (numeroDigitado < numeroAleatorio)
        {
            Console.WriteLine("O numero digitado foi menor que o numero secreto");
        }

        else
        {
            Console.WriteLine("O número digitado foi maior que o numero secreto");
        }

        int diferencaNumerica = Math.Abs(numeroAleatorio - numeroDigitado);

        if (diferencaNumerica >= 10)
        {
            pontuacao -= 100;
        }
        else if (diferencaNumerica >= 5)
        {
            pontuacao -= 50;
        }
        else
        {
            pontuacao -= 20;
        }

        Console.WriteLine("-----------------------------");
        Console.WriteLine("Sua pontuação é " + pontuacao);
        Console.WriteLine("-----------------------------");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Digite ENTER para continuar... ");
        Console.WriteLine("-----------------------------");
        Console.ReadLine();

    }


    Console.WriteLine();
    Console.WriteLine("Deseja continuar? S/N: ");
    string opcaoContinuar = Console.ReadLine();


    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jodoDeveContinuar = false;
    }
}
