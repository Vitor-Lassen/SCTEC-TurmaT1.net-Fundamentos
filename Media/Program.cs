Console.WriteLine("Bem vindo ao programa de calculo de media: ");

Console.Write("Digite uma Media para começar: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a segunda nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a ultima nota: ");
double nota3 = Convert.ToDouble(Console.ReadLine());
//Existe tambem o casting que seria um parentese forçando o tipo : (double)

double media = (nota1 + nota2 + nota3) / 3;

// Vamos implementar a logica de aprovação do aluno, baseado na media calculada


// Se Média >= 7 = Aluno Aprovado
// Se Média  >= 5  e < 7  Em recuperação
// Se Media <5  Reprovado


// cenario com maior validação usando somente ifs 
// if (media >= 7)
// {
//     Console.WriteLine($"Aluno aprovado! com média de: {media:F2}");
// }

// if (media >=5)
// {
//     if (media < 7)
//     {
//         Console.WriteLine($"Aluno em recuperacao! com média de: {media:F2}");
//     }
// }

// if (media <5)
// {
//     Console.WriteLine($"Aluno Reprovado! com média de: {media:F2}");
// }


//cenario parcial usando. if else 
if (media >= 7)
{
    Console.WriteLine($"Aluno aprovado! com média de: {media:F2}");
}
else {
    if (media >=5)
    {
        Console.WriteLine($"Aluno em recuperacao! com média de: {media:F2}");
    }
}

if (media<5)
{
    Console.WriteLine($"Aluno Reprovado! com média de: {media:F2}");
}

//cenário mais otimizado usando else if 
if (media >= 7)
{
    Console.WriteLine($"Aluno aprovado! com média de: {media:F2}");
}
else {
    if (media >=5)
    {
        Console.WriteLine($"Aluno em recuperacao! com média de: {media:F2}");
    }
    else 
    {
        Console.WriteLine($"Aluno Reprovado! com média de: {media:F2}");
    }
}


