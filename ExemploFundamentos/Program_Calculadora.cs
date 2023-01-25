//  using ExemploFundamentos.Models;

//  Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 30);
// calc.Multiplicar(10,30);
// calc.Dividir(10,30);
// calc.Potencia(10,2);
// calc.Seno(60);
// calc.Cosseno(100);
// calc.Tangente(180);
// calc.RaizQuadrada(4);

//fazendo incremento e decremento de valores com Console.ReadLine

// Console.WriteLine($"O valor da variavel eh:");
// string numero = Console.ReadLine();
// int numeroInteiro = Convert.ToInt32(numero);
// numeroInteiro++;
// Console.WriteLine($"O valor da variavel +1 eh {numeroInteiro}");
// numeroInteiro--;
// Console.WriteLine($"O valor da variavel -1 eh {numeroInteiro}");

//=============Exemlpos de laços==================

//Laço com for:
//Exemplo do `for(declaracao da variavel; condicao de parada; o quanto o meu contador ira alterar)` fazenddo uma tabuada;
//Sempre que a condicao do laco for false, ele encerra a repeticao;
//Exemplo: FACA UMA TABOADO DO 5:
//programa:
// using ExemploFundamentos.Models;

// int numero = 5;

// for (int contador = 0; contador<=10; contador++)
// {
//     Console.WriteLine($"A tabuado do {numero} eh: {numero}x{contador}={numero*contador}");
// }

//Laço com while:
//Encontre uma condicao verdadeira e continue o laco --> while(condicao veradeira);
//While nao tem contador, logo a gente precisa gerenciar a contagem;
//Uma maneira de quebrar o laco alem da condicao de parada ppelo contador eh usando a palavra `break`;
//Exemplo: FACA UMA TABOADO DO 5:
//programa:

// using ExemploFundamentos.Models;

// int numero = 5;
// int contador = 0;

// while(contador<=10)
// {
//     Console.WriteLine($"A tabuado do {numero} eh: {numero}x{contador}={numero*contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }

////Laço com do While():
// O 'do' sempre sera feito ai quando chegar no while ele vai ficar procurando a condicao verdadeira para continuar o laco

// Ex.:

// do{
// }while(condicao veradeira);

// While nao tem contador, logo a gente precisa gerenciar a contagem;
// Uma maneira de quebrar o laco alem da condicao de parada pelo contador eh usando a palavra `break`;
// programa, inputa numeros no console e quando o numero zero for inputado, faca uma soma de todos os numeros inputados:

// using ExemploFundamentos.Models;
// int soma=0, numero = 0;

// do 
// {
//     Console.WriteLine("Digite um numero (zero para parar o laco):");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while(numero!=0);

// Console.WriteLine($"Total da soma eh {soma}");

//======================================================================================================================================================================================================================================================================================
//*CONSTRUINDO UM MENU INTERATIVO:

// using ExemploFundamentos.Models;

// string opcao;

// while(true)
// {
//     Console.WriteLine("Digite a sua opcao:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");//significa encerrar o programa
//             Environment.Exit(0);//encerrar programa saindo do laco
//             break;

//         default:
//             Console.WriteLine("Opcao nao existente");
//             break;
//     }

// }

//outra maneira de sair do laco do switch case

// using ExemploFundamentos.Models;

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.WriteLine("Digite a sua opcao:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");//significa encerrar o programa
//             exibirMenu=false;//encerrar programa saindo do laco
//             break;

//         default:
//             Console.WriteLine("Opcao nao existente");
//             break;
//     }
// }
//======================================================================================================================================================================================================================================================================================

//ARRAY E LISTAS

// using ExemploFundamentos.Models;

// int[] arrayInteiros = new int[3]; //total de 3 no indice

// arrayInteiros[0] = 72; //--indice 1
// arrayInteiros[1] = 64; //--indice 2
// arrayInteiros[2] = 50; //--indice 3

// //para printar um array faca um laco de repeticao que vao percorrer pelos indices
// Console.WriteLine("Percorrendo o meu array com o FOR");

// for(int contador=0; contador < arrayInteiros.Length; contador++)
// {
// 	Console.WriteLine($"Posicao numero {contador} = {arrayInteiros[contador]}");
// }

// //Percorrendo o meu array com o FOREACH
// Console.WriteLine("Percorrendo o meu array com o FOREACH");
// //uma fesvantagem do foreac eh que com ele nao tem como saber em qual indice o array se encontra, a nao ser q vc faca um pprograma com o contador auxiliar
// int contadorForeach =0;
// foreach (int valorarrayInteiros in arrayInteiros)
// {
//     Console.WriteLine(valorarrayInteiros);
//     //abaixo estara um print para o terminal com o intuito de saber qual indice o foreac se encontra
//     contadorForeach++;
//     Console.WriteLine($"Posicao numero {contadorForeach} = {valorarrayInteiros}");
// }


//======================================================================================================================================================================================================================================================================================

//AUMENTANDO A CAPACIDADE DO ARRAY 

//ex.1(FEITO PELO CAIO E NAO PELO PROFESSOR):

// using ExemploFundamentos.Models;

// int indiceArray=0;

// Console.WriteLine("Coloque abaixo o tamanho do seu array:");
// indiceArray = Convert.ToInt32(Console.ReadLine());

// int[] arrayInteiros = new int[indiceArray];

// Console.WriteLine("Percorrendo o meu array com o FOREACH");
// //uma vantagem do foreac eh que com ele nao tem como saber em qual indice o array se encontra, a nao ser q vc faca um pprograma com o contador auxiliar
// int contadorForeach =0;
// foreach (int valorarrayInteiros in arrayInteiros)
// {
//     Console.WriteLine(valorarrayInteiros);
//      //abaixo estara um print para o terminal com o intuito de saber qual indice o foreac se encontra
//      contadorForeach++;
//      Console.WriteLine($"Posicao numero {contadorForeach} = {valorarrayInteiros}");
// }

//REDIMENSIONANDDO UTILIZANDO A CLASSE Array.Resize (FEITO PELO PROFESSOR)

// using System;
// using ExemploFundamentos.Common.Models;


// int[] arrayInteiros = new int[3]; //total de 3 no indice

// arrayInteiros[0] = 72; //--indice 1
// arrayInteiros[1] = 64; //--indice 2
// arrayInteiros[2] = 50; //--indice 3

// int indiceArray=0;
// Console.WriteLine("Coloque abaixo o tamanho do seu array:");
// indiceArray = Convert.ToInt32(Console.ReadLine());

// Array.Resize(ref arrayInteiros, arrayInteiros.Length + indiceArray);
// Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);
// //para printar um array faca um laco de repeticao que vao percorrer pelos indices
// Console.WriteLine("Percorrendo o meu array com o FOR");

// for(int contador=0; contador < arrayInteiros.Length; contador++)
// {
//    	Console.WriteLine($"Posicao numero {contador} = {arrayInteiros[contador]}");
// }

// //==============================================================================

// //*PROGRAMA DE COMO COPIAR UM ARRAY
// using ExemploFundamentos.Common.Models;
// using System;

// int[] arrayInteiros = new int[3]; //array qque sera copiado

// arrayInteiros[0] = 72; //--indice 1
// arrayInteiros[1] = 64; //--indice 2
// arrayInteiros[2] = 50; //--indice 3

// int[] arrayInterirosCopia = new int[arrayInteiros.Length*2];
// Array.Copy(arrayInteiros, arrayInterirosCopia, arrayInteiros.Length);



// //para printar um array faca um laco de repeticao que vao percorrer pelos indices
//  Console.WriteLine("Percorrendo o meu array com o FOR");

// for(int contador=0; contador < arrayInterirosCopia.Length; contador++)
//  {
//   	Console.WriteLine($"Posicao numero {contador} = {arrayInterirosCopia[contador]}");
//  }










// //PROGRAMA CRIANDO UMA LISTA

// using ExemploFundamentos.Common.Models;
// using System;

// List<string> listaString = new List<string>();

// listaString.Add("C");
// listaString.Add("a");
// listaString.Add("i");
// listaString.Add("o");

// Console.WriteLine("Printando pelo for");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
// 	Console.WriteLine($"indice n {contador+1} = dado {listaString[contador]} da lista");
// }

// Console.WriteLine("Printando pelo foreach");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
// 	Console.WriteLine($"indice n {contadorForeach+1} = dado {item} da lista");
// 	contadorForeach++;
// }
















/*
using ExemploFundamentos.Common.Models;
using System;

int digito;
int soma = 0;
int multiplicacao = 1;
int resultado = 0;
int numero;
Console.WriteLine("Coloque o numero");
numero = Convert.ToInt32(Console.ReadLine());

//estrutura de repeticao

while (numero > 0)
{
    digito = numero % 10; //pegando o ultimo digito
    soma = soma + digito;
    numero = numero / 10;
    multiplicacao = multiplicacao * digito;
}

resultado = multiplicacao - soma;

Console.WriteLine($"valor eh {resultado}");
*/
