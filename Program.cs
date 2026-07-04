Console.WriteLine("Hello, World!");

int num1 = 5; 
Console.WriteLine(num1);


// string nome = "Vitor";
// //Aspas simples devem ser utilizadas quando o tipo é caractere. 
// char caractere = 't';

// //quero inserir um unico caractere em uma string
// string umCaractere = "s";//posso colocar ao lado do código mas sempre a direita


//Este é o comentário in line 


/*
posso utilizar diversas linhas comentadas
no comentátio em bloco 
*/


// é possivel uar o atalho para comentar varias linhas selecionando as 
// e pressionando ctrl+k + ctrl+c  ou  ctrl+;
// e para remover os comentatios utililize o atalho ctrl+k + ctrl+u ou ctrl+;


string primeiroNome = "Vitor";
string sobrenome = "Lassen";

var nomeCompleto = primeiroNome + " " + sobrenome;

Console.WriteLine(nomeCompleto);

num1 = 7;  //num 1 foi criada la encima, por isso. não precisamos declarar (criar) ela novamente
int num2 = 2;

int resultado = num1 + num2;

string apresentarResultado = "o resultado da soma de " + num1 + " e " + num2 + " é igual a: "+ resultado;
string apresentarResultadoTemplate = $"o resultado da soma de {num1} e {num2} é igual a: {resultado}";


Console.WriteLine(apresentarResultado);
Console.WriteLine(apresentarResultadoTemplate);


//somar o mesmo numero

int soma = 5; 

soma = soma+1;
Console.WriteLine("o resultado de soma = soma + 1 é : "+ soma);

soma =5; //resetar a variavel para mostrar que todas as formas dao o mesmo resultado
soma += 1; 
Console.WriteLine("o resultado de soma += 1 é : "+ soma);

soma =5; //resetar a variavel para mostrar que todas as formas dao o mesmo resultado
soma++;
Console.WriteLine("o resultado de soma ++ é : "+ soma);


//se soma++ incrementa 1 oq faz o soma--?
soma--;
Console.WriteLine("o resultado de soma -- é : "+ soma);


//somar e subtrair  o mesmo numero

soma = 5; 

soma = soma+1;
Console.WriteLine("o resultado de soma = soma + 1 é : "+ soma);
soma = soma -1; 

soma += 1; 
Console.WriteLine("o resultado de soma += 1 é : "+ soma);
soma -= 1;

soma++;
Console.WriteLine("o resultado de soma ++ é : "+ soma);

//se soma++ incrementa 1 oq faz o soma--?
soma--;
Console.WriteLine("o resultado de soma -- é : "+ soma);
