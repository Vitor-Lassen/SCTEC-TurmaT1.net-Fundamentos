// Console.WriteLine("Digite a idade: ");
// int idade = Convert.ToInt32(Console.ReadLine());


// if (idade > 18 && idade < 60)
// {
//     Console.WriteLine("Você é um adulto.");
// }
// else if (idade >= 60)
// {
//     Console.WriteLine("Você é um idoso.");
// }
// else
// {
//     Console.WriteLine("Você é uma criança ou adolescente.");
// }

// if (idade > 60)
// {
//     Console.WriteLine("Você é um idoso.");
// }
// else if (idade >= 18)
// {
//     Console.WriteLine("Você é um adulto.");
// }
// else
// {
//     Console.WriteLine("Você é uma criança ou adolescente.");
// }



//Uso da negacao para inverter o valor de uma variavel booleana

int idade = 15;
var ehMaior = idade > 18;

if (!ehMaior)
{
    Console.WriteLine("Você é menor de idade.");
}


// Peça o valor da compra e informe:
// Se valor ≥ 500 → Desconto de 20%
// Se valor entre 200 e 499 → Desconto de 10%
// Se valor < 200 → Sem desconto
// Calcule o valor final e o apresente juntamente com o percentual de desconto aplicado 


Console.WriteLine("Digite o valor da compra: ");
decimal valor  = decimal.Parse(Console.ReadLine());

decimal percentualDesc  ; 
if (valor >= 200 && valor < 500)
{
    percentualDesc = 0.1m;
}
else if (valor >= 500)
{
    percentualDesc = 0.2m;
}
else
{
    percentualDesc = 0;
}

decimal valorFinal = valor * ( 1 - percentualDesc);

Console.WriteLine("O valor com desconto foi de : " + valorFinal );