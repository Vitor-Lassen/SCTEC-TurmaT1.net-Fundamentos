//Leia um número inteiro N. Se N for positivo (maior que zero) imprima "Positivo"; caso contrário, imprima "Não Positivo".

Console.WriteLine("Digite um número inteiro:");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    Console.WriteLine("Positivo");
}
else
{
    Console.WriteLine("Não positivo");
}

//Leia um número inteiro N. verifique se N é múltiplo de 5 se for imprimir "Múltiplo de 5" , caso contrário imprimir "Não é múltiplo de 5".

Console.WriteLine("Digite um número inteiro:");
int n = int.Parse(Console.ReadLine());

if (n % 5 == 0)
{
    Console.WriteLine("Múltiplo de 5");
}
else
{
    Console.WriteLine("Não Múltiplo de 5");
}
