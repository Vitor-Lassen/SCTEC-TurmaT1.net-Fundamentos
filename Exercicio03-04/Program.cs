using System.Runtime.InteropServices;
using System.Runtime.Serialization;

Console.Write("Bem Vindo ao programa analise de credito!\n\nDigite a renda do cliente: ");
decimal renda = decimal.Parse(Console.ReadLine());

Console.Write("\nDigite a a idade  do cliente: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("\nDigite se o cliente esta negativado (Digite N - para Não negativado e S para negativo):  ");
char negativado  = char.Parse(Console.ReadLine());



//solução valida baseada no fluxograma do leo. 
if (negativado == 'S' || negativado == 's')
{
    Console.WriteLine("Credito Negado!");
}
else
{
    if (idade >= 18 && idade <= 65)
    {
        if( renda >= 8000)
        {
            Console.WriteLine("Crédito Aprovado!");

        }
        else
        {
            if (renda >= 3000)
            {
                Console.WriteLine("Credito. em analise");
            }
            else
            {
                Console.WriteLine("Credito Negado!");
            }
        }
    }
    else
    {
        Console.WriteLine("Credito Negado!");
    }
}



//solução valida baseada no fluxograma do leo.  solução simplificada
if (negativado == 'S' 
    || negativado == 's'  
    || idade < 18 || idade > 65)
{
    Console.WriteLine("Credito Negado!");
}
else
{
  
    if( renda >= 8000)
    {
        Console.WriteLine("Crédito Aprovado!");
    }
    else
    {
        if (renda >= 3000)
        {
            Console.WriteLine("Credito. em analise");
        }
        else
        {
            Console.WriteLine("Credito Negado!");
        }
    }
   
}


//solução valida baseada no fluxograma da sugestão 

if ( renda >= 3000) 
{
    if (negativado == 'n' || negativado == 'N')
    {
        if (idade >= 18 && idade <= 65)
        {
            if (renda >= 8000)
            {
                Console.WriteLine("Crédito Aprovado!");
            }
            else
            {
                Console.WriteLine("Credito. em analise");
            }
        }
        else
        {
            Console.WriteLine("Credito Negado!");
        }
    }
    else
    {
        Console.WriteLine("Credito Negado!");
    }
}
else
{
    Console.WriteLine("Credito Negado!");
}


//solução valida baseada no fluxograma da sugestão  -- otimizada

if (renda >= 3000
    && (negativado == 'n' || negativado == 'N') 
    && idade >= 18 && idade <= 65)
{ 
    if (renda >= 8000)
    {
        Console.WriteLine("Crédito Aprovado!");
    }
    else
    {
        Console.WriteLine("Credito. em analise");
    }
}
else
{
    Console.WriteLine("Credito Negado!");
}
 


 // codigo marlon  -- Outra sugestão de solução para o problema do fluxograma 
 
 Console.WriteLine("Digite sua renda mensal:");
 renda = decimal.Parse(Console.ReadLine());
Console.WriteLine("Possui dívida inadimplente? (sim ou não)");
string divida = Console.ReadLine();
Console.WriteLine("Qual sua idade?");
 idade = int.Parse(Console.ReadLine());
if (renda >= 8000 && divida == "não" ){
    Console.WriteLine("Crédito aprovado.");
}
else 
{
    if (renda < 3000 || divida == "sim" || idade < 18 || idade > 65){
        Console.WriteLine("Crédito negado.");
    }
    else if (renda > 3000 && renda < 8000 || divida == "não" || idade >= 18 || idade < 65)
    {
        Console.WriteLine("Crédito em analise.");
    } 
}




//Exercicio 04  


Console.WriteLine("Bem vindo ao calculo de frete \n\n\n Digite a distancia em km do local de entrega: ");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso do produto em kg: ");
double peso = double.Parse(Console.ReadLine());
Console.WriteLine("digite o tipo do cliente (Digite P para premium e C para comum): ");
string tipoCliente = Console.ReadLine();



if ( distancia  > 0 && 
    peso > 0 && 
    (tipoCliente.ToUpper() == "P" || tipoCliente.ToUpper() == "C"))
{
    double freteBase = distancia * 1.5;

    double taxa = 0;

    if (tipoCliente.ToUpper() == "P" && peso <200)
    {
        taxa += -0.15;
    } 
    if (peso > 100)
    {
        taxa += 0.12;  // taxa = taxa + 0.12
    }
    if (peso > 150 && distancia > 1000)
    {
        taxa += 0.08;
    }

    double freteFinal =  freteBase * (1+taxa); //freteBase + (freteBase * taxa);

    Console.WriteLine($"O valor do frete é: {freteFinal:C2}");
}
else 
{
    Console.WriteLine("Dados invalidos");
}