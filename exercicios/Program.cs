//Converter temperatura Celsius para Fahrenheit.    F=C⋅9/5+32
Console.Write("Digite a temperatira em celsius para ser convertida: ");

float celsius = float.Parse(Console.ReadLine());

float fahrenheit = celsius * 9/5 +32;

Console.WriteLine($"O valor de {celsius:F2} Celsius em Fahrenheit é de {fahrenheit:F2}");


//Par ou Ímpar: Usar o operador de módulo (%).

Console.WriteLine("Digite o valor para saber se ele é par ou impar");


//Parse server para converter o texto lido que o usuario escrever para o tipo da variavel.
int numero = int.Parse(Console.ReadLine());

int ehPar = numero % 2;

if (ehPar == 0)
{
    Console.WriteLine($"O numero {numero} é Par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}
