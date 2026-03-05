
// Requisito 1: Nossa calculadora deve permitir a soma de dois numeros
// Requisito 2: Nossa calculadora deve permitir a subtraçao de dois numeros
// Requisito 3: Nossa calculadora deve permitir a multiplicaçao de dois numeros
// Requisito 4: Nossa calculadora deve permitir a divisao de dois numeros
// Requisito 5: Nossa calculadora deve permitir a execuçao de multiplas operaçoes

bool deveContinuar = true;

while (deveContinuar == true)
{
    // Console.Clear();


    Console.WriteLine("--------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("--------------------------");

    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - Subtraçao");
    Console.WriteLine("3 - Multiplicaçao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma opçao valida: ");
    String operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S")
    {
        deveContinuar = false;

        continue;
    }

    Console.Write("Digite o primeiro numero: ");
    String strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo numero: ");
    String strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("o primeiro numero digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo numero digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    bool primeiroNumeroVazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumeroVazio = string.IsNullOrEmpty(strSegundoNumero);

    if (primeiroNumeroVazio == true || segundoNumeroVazio == true)
    {
        Console.WriteLine("Digite um numero valido!");
        Console.ReadLine();

        continue;
    }

    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

    decimal resultado;

    switch (operacaoSelecionada) // operador do switch
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            break;

        case "3":
            resultado = primeiroNumero * segundoNumero;
            break;

        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Nao e possivel fazer uma divisao por zero. Tente novamente. ");

                return;
            }

            resultado = primeiroNumero / segundoNumero;
            break;

        default:
            Console.WriteLine("Selecione uma opçao valida!");
            Console.ReadLine();

            continue;

    }

    Console.WriteLine("A operaçao dos dois numeros resulta em: " + resultado);


    Console.ReadLine();

}



