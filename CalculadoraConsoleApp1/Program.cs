// Requisito 1: Nossa calculadora deve permitir a soma de dois numeros
// Requisito 2: Nossa calculadora deve permitir a subtraçao de dois numeros
// Requisito 3: Nossa calculadora deve permitir a multiplicaçao de dois numeros
// Requisito 4: Nossa calculadora deve permitir a divisao de dois numeros
// Requisito 5: Nossa calculadora deve permitir a execuçao de multiplas operaçoes
// Requisito 6: Nossa calculadora deve dar a possibilidade de produzir a tabuada de um numero informado
// Requisito 7: Nossa calculadora deve dar a possibilidade de visualizar o historico de operaçoes

string[] historicoOperacoes = new string[100];
int contadorOperacoes = 0; 

while (true)
{
    // Console.Clear();


    Console.WriteLine("--------------------------");
    Console.WriteLine("Calculadora 2026");
    Console.WriteLine("--------------------------");

    Console.WriteLine("1 - soma");
    Console.WriteLine("2 - Subtraçao");
    Console.WriteLine("3 - Multiplicaçao");
    Console.WriteLine("4 - Divisao");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Historico de operaçoes");
    Console.WriteLine("S - Sair");

    Console.WriteLine();

    Console.Write("Selecione uma opçao valida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {  
        return;
    }

    // Logica da tabuada
    if (operacaoSelecionada == "5")
    {
        Console.Write("Digite um numero para gerar a tabuada: ");

        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        // para cada....
        // 1. contador/iterador
        // 2. enquanto a condiçao for verdadeira
        // 3. iteraçao da variavel contadora
        for (int contador = 1; contador <= 10; contador = contador + 1)
        {
            int resultadoTabuada = numeroTabuada * contador;

            string operacaoTabuada = numeroTabuada + " x " + contador + " = " + resultadoTabuada;

            Console.WriteLine(operacaoTabuada);
        }

        Console.ReadLine();

        continue;
    }

    else if (operacaoSelecionada == "6") // Visualizar o historico de operaçoes
    {
        Console.WriteLine("Historico de operaçoes: ");
        Console.WriteLine("----------------------------------------");
        
        for (int contador = 0; contador < contadorOperacoes; contador++)
        {
            Console.WriteLine(historicoOperacoes[contador]);
        }

        Console.ReadLine();

        continue;
    }
    
    
    // Logica das operaçoes de calculo

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

    string textoOperacao;

    switch (operacaoSelecionada) // operador do switch
    {
        case "1":
            resultado = primeiroNumero + segundoNumero;
            textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            break;

        case "2":
            resultado = primeiroNumero - segundoNumero;
            textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            break;

        case "3":
            resultado = primeiroNumero * segundoNumero;
            textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
            break;

        case "4":
            if (segundoNumero == 0)
            {
                Console.WriteLine("Nao e possivel fazer uma divisao por zero. Tente novamente. ");

                continue;
            }

            resultado = primeiroNumero / segundoNumero;
            textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            break;

        default:
            Console.WriteLine("Selecione uma opçao valida!");
            Console.ReadLine();

            continue;

    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[contadorOperacoes] = textoOperacao;

        contadorOperacoes = contadorOperacoes + 1;
    }

    Console.WriteLine("A operaçao dos dois numeros resulta em: " + resultado);


    Console.ReadLine();

}



