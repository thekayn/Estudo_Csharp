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

using ExemploFundamentos.Models;

string opcao;

while(true)
{
    Console.WriteLine("Digite a sua opcao:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");//significa encerrar o programa
            Environment.Exit(0);//encerrar programa saindo do laco
            break;

        default:
            Console.WriteLine("Opcao nao existente");
            break;
    }

}

//======================================================================================================================================================================================================================================================================================




