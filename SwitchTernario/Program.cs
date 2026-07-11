//menu de aplicacao com if: 
Console.WriteLine("Menu da Aplicacao");
Console.WriteLine("1 - Opcao 1");
Console.WriteLine("2 - Opcao 2");
Console.WriteLine("3 - Opcao 3");
Console.Write("Escolha uma opcao: ");

string? escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine("Voce escolheu a Opcao 1");
}

if (escolha == "2")
{
    Console.WriteLine("Voce escolheu a Opcao 2");
}

if (escolha == "3")
{
    Console.WriteLine("Voce escolheu a Opcao 3");
}

if (escolha != "1" && escolha != "2" && escolha != "3")
{
    Console.WriteLine("Opcao invalida");
}



//menu usando switch case:

//menu de aplicacao com if: 
Console.WriteLine("Menu da Aplicacao");
Console.WriteLine("1 - Opcao 1");
Console.WriteLine("2 - Opcao 2");
Console.WriteLine("3 - Opcao 3");
Console.Write("Escolha uma opcao: ");

string? selecao = Console.ReadLine();


switch (selecao)
{
    case "1": 
        Console.WriteLine("Voce escolheu a Opcao 1");
        break;
    case "2":
        Console.WriteLine("Voce escolheu a Opcao 2");
        break;
    case "3": 
        Console.WriteLine("Voce escolheu a Opcao 3");
        break;
    default:
        Console.WriteLine("Opcao invalida");
        break;
}



// If ternario:

int idade = 18;
string ehMaior; 

if ( idade >= 18)
{
    ehMaior = "Pessoa maior de idade";
}
else
{
    ehMaior = "Pessoa menor de Idade"; 
}
Console.WriteLine(ehMaior);

string ehMaiorTernario = (idade > 18) ? "Pessoa maior de idade" : "Pessoa menor de idade";