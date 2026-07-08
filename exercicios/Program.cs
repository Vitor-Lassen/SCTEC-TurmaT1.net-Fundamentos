//Converter temperatura Celsius para Fahrenheit.    F=C⋅9/5+32
Console.Write("Digite a temperatira em celsius para ser convertida: ");

float celsius = float.Parse(Console.ReadLine());

float fahrenheit = celsius * 9/5 +32;

Console.WriteLine($"O valor de {celsius:F2} Celsius em Fahrenheit é de {fahrenheit:F2}");


//Par ou Ímpar: Usar o operador de módulo (%).

Console.WriteLine("Digite o valor para saber se ele é par ou impar");


//Parse server para converter o texto lido que o usuario escrever para o tipo da variavel.
int numero = int.Parse(Console.ReadLine());
int resultado = numero % 2;

//Sempre que utilizamos os operadores ==, >=, > ou <=, o resultado da operação é um valor booleano (true ou false).
bool condicao = resultado == 0;
if (condicao)
{
    Console.WriteLine($"O numero {numero} é Par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}

bool ehPar = (numero % 2) == 0;
//if (ehPar == true )
if (ehPar)
{
    Console.WriteLine($"O numero {numero} é Par");
}
else
{
    Console.WriteLine($"O numero {numero} é impar");
}


// exercicio Calculadora IMC: Peso / (Altura * Altura).


Console.WriteLine("Digite o seu peso em kg: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a sua altura em metros: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);

Console.WriteLine($"O seu IMC é de {imc:F2}");


//Maior de Três: Ler 3 números e achar o maior.
Console.WriteLine("Digite Tres numeros: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine($"o numero {num1} é o maior");
    }
    else
    {
        Console.WriteLine($"o numero {num3} é o maior");
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine($"o numero {num2} é o maior");
    }
    else
    {
        Console.WriteLine($"o numero {num3} é o maior");
    }
}


//Calcular o bônus salarial (15% se tempo > 5 anos, senão 5%).

Console.WriteLine("Vamos calcular o bonus");
Console.Write("Digite o salario: ");
decimal salario = decimal.Parse(Console.ReadLine());
Console.Write("Digite o Tempo de casa em anos: ");
int anos = int.Parse(Console.ReadLine());

decimal bonus;

if (anos > 5)
{
    bonus = salario * (decimal)0.15 + 100;
}
else
{
    bonus = salario * (decimal)0.05 +100;
}
Console.WriteLine($"O bonus do funcionario é de {bonus:C2}");


decimal percentual;
if (anos > 5 )
{
    percentual = 0.15m;
}
else
{
    percentual = 0.05m;
}

decimal bonus2 = salario * percentual +100;
Console.WriteLine($"O bonus do funcionario é de {bonus2:C2}");