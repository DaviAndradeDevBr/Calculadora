
// Requisito 1: Nossa calculadora deve permitir a soma de dois numeros
// Requisito 2: Nossa calculadora deve permitir a subtraçao de dois numeros
// Requisito 3: Nossa calculadora deve permitir a multiplicaçao de dois numeros
// Requisito 4: Nossa calculadora deve permitir a divisao de dois numeros
// Requisito 5: Nossa calculadora deve permitir a execuçao de multiplas operaçoes

bool deveContinuar = true; // atribuiçao

while (deveContinuar == true) // condiçao
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

    // int = numero inteiro
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;

    if (operacaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }

    else if (operacaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }

    else if (operacaoSelecionada == "3")
    
    {
        resultado = primeiroNumero + segundoNumero;
    }

    else
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("Nao e possivel fazer uma divisao, tente novamente.");
    
            return;
        }

        resultado = primeiroNumero + segundoNumero;
    }

    Console.WriteLine("a soma dos dois numeros resulta em: " + resultado);

    Console.ReadLine();
}