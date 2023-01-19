// using ExemploFundamentos.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome="kayn";
// pessoa1.Idade = 110;
// pessoa1.Apresentar();

// Console.WriteLine(pessoa1.Nome);

//"ctrl+c+k = //"

//======================================================================================================================================================================================================================================================================================//
//explicacao da aula de atribuicao

// int a = 0;
// int b = 0;

// a = 20;
// b = 10;

// int c = a+b;

// Console.WriteLine(c);

//===============================================================================//
//Conversao para o type string
// int Valor_Inteiro = 5;
// string a = Valor_Inteiro.ToString();
// Console.WriteLine(a);

//======================================================================================================================================================================================================================================================================================//
//Teste de logica
	//  int QuantidadeEmEstoque = 10;
	//  int QuantidadeDeCompra = 0;
	//  bool PossivelVenda = QuantidadeEmEstoque >= QuantidadeDeCompra;

	//  Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}");
	//  Console.WriteLine($"Quantidade de compra: {QuantidadeDeCompra}");
	 
	 
	//  if (QuantidadeDeCompra==0)
	//  {
	//  Console.WriteLine("Impossivel efetuar a compra!");	
	//  PossivelVenda = false;
	//  Console.WriteLine($"É possivel realizar a venda? {PossivelVenda}");
	//  }

	// 	else if (PossivelVenda)
	// 	{
	//  	Console.WriteLine("Venda realizada");
	// 	}

	// 		else
	//  		{
	//  		Console.WriteLine("Desculpa, nao temos essa quantidade em estoque.");
	// 		}
//======================================================================================================================================================================================================================================================================================
//Teste utilizando o switch case
// using ExemploFundamentos.Models;

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
// 	Console.WriteLine("Vogal");
// }

// else if (letra == "e")
// {
// 	Console.WriteLine("Vogal");
// }
								 
// else if (letra == "i")
// {
// 	Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
// 	Console.WriteLine("Vogal");
// }	 

// else if (letra == "u")
// {
// 	Console.WriteLine("Vogal");
// }

// else
// {
// 	Console.WriteLine("Não é uma Vogal");
// }

//Primeiro vamos fazer um codigo sem estar usando o switch case:
	// using ExemploFundamentos.Models;	
	// Console.Write("Digite uma letra:");
	// string letra = Console.ReadLine();

	// if(letra == "a"||letra == "e"||letra=="i"||letra=="o"||letra=="u")
	// {
	// Console.WriteLine("Vogal");
	// }
	// else
	// {
	// Console.WriteLine("Não é uma vogal");
	// }

//usando o switch case

	// using ExemploFundamentos.Models;	
	//  Console.Write("Digite uma letra:");
	//  string letra = Console.ReadLine();

	// switch(letra)
	//  {
	//  case "a":
	//  case "e":
	//  case "i":
	//  case "o":
	//  case "u":

	//  	Console.WriteLine("Vogal");
	//  	break;
	//  default:
	//  	Console.WriteLine("Não é vogal.");
	//  	break;
	//  }

	//usando operador &&

	// using ExemploFundamentos.Models;
	// bool possuiPresencaMinima = true;
	// double media = 6.5;

	// if (possuiPresencaMinima && media>= 7)
	// {
	// Console.WriteLine("Aprovado.");
	// }
	// else
	// {
	// Console.WriteLine("Reprovado.");
	// }