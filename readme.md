# Estudo de C#

### INFELISMENTE, QUANDO EU COMECEI A FAZER O BOOTCAMP DA DIO ELE JÁ ESTAVA PERTO DO FINAL, POR ISSO CONTINUEI OS MEUS ESTUDOS POR MEIO DE LIVROS E OUTRAS PLATAFORMAS, MAS QUAIS ESTARÃO AQUI NO MEU GITHUB E NO MEDIUM

***

### Aqui estarão alguns resumos das aulas, e está sendo bacana ver o quanto eu já melhorei com alguns meses de prática.

***

## SINTAXE E INDENTAÇÃO

### **Entendendo a estrutura de um projeto:**

	Como é composto um projeto?

		Ao digitar "dotnet new console" ele cria a pasta com dois arquivos, o primeiro com o nome "Program.cs" é a sua classe, la é onde vc vai fazer a codificação, o segundo arqyuivo é o ".csproj", ele é um arquivo de projeto do #C, nele vc tem informações essenciais, la estao os metadados na linguagem xml.
		
		Coisas escritas nesse arquivo: Exe= arquivo executavel


Na maioria das vezes nao existe a necessidade de mexer no arquivo ".csproj"
		
* A pasta "obj":
Nela fala e contem os arquivos de Debug, na maioria das vezes nao precisara mexer nessa pasta, mas é bom saber que ela existe, e que quando tiver alguma compilação e debug, ele será alimentada;


* Pasta "bin":
É a pasta de binario, antes de ser feita a compilacao, a sua pasta "ref" estara vazia, apos a compilacao, serao acrescentados alguns arquivos dentro dela, como ".exe", ".json", ".dll" e "pdb";

* Boa pratica:
Criar no diretorio (dentro do vscode), um novo arquivo (new file) ".json" com o nome config la podera estar escrito:

		{
			"VersaoProjeto": "v1"
			"Autor": "CaioStefani"
		}


***
### **Conceito de classe:**

Uma abstração é pegar um obejto da vida real e transformar em um objeto na programação;
Classe (tem atributos e metodos(), é o molde, é o conceito do mundo real, mas na programação)
	ela primeiro tem os atributos
	em seguida tem os metodos, os metodos sao reprensentados com parenteses
Objeto (é a classe, mas com uma identificação)
Metodo() (é a ação que a classe irá fazer)
Atributo sao as variaveis da classe

*** 
* CRIANDO NOSSA CLASSE NO CODIGO: 
  * Vai no diretorio e aperto com o botao direito;
  * Clique no "new folder" e de o nome de "Models";
  * Clique nesse "Models" com o botao direito e clique em "new", depois "class";
  * De um nome a classe;
  * Apos ter dado o nome tera um arquivo para editar (esse arquivo é a classe);
  * Dentro desse arquivo teremos que colocar as propriedades da classe;
  * digite -> prop, sendo, prop = de propriedade;
  * Apos digitar "prop" aparece a sintase dela, na qual aparece o tipo da variavel e o nome da variavel;
  
* Ex.: 
		
		puclic int(tipo) MyProperty (nome da propriedade) {get; set;}

* Apos ter criado as propriedades, crie os metodos (acoes que a  classe pode fazer) para fazer isso digite: 
	
		puclic void "metodo"()
							{
							}
Para escrever uma informacao no terminal digite: 

		Console.WriteLine($"");

***

### **ENTENDENDO A ESTRUTURA DE CODIGO**

obs.: "console" é uma classe e "WriteLine" é um metodo (funçao), logo, "Console.WhiteLine()" é a mesma coisa que "Pessoa.Apresentar()", na qual, "Pessoa" é a classe e "Apresentar" é o metodo;

***

### **SINTAXE E TIPOS DE DADOS EM C#**
  
Para instanciar o programa precisamos executar o arquivo "Program.cs":

1) colocar o "namespace" da classe utilizada, esse namespace é como se fosse o caminho do id (identificação, nesse caso é o diretorio que ela se encontra) (podem existir classes com o mesmo nome, mas o id tem que ser difirente).

Digite: using "nome do diretorio";

Ex.: 

		using ExemploFundamentos.Models;

2)inicialize a classe em questao:

Ex.: 

		Pessoa p = new Pessoa();

***

* USANDO A CLASSE PESSOA:
  
Instanciando a uma variavel da classe pessoa;
1) Pessoa "nome da variavel" = new Pessoa();
   
ex.: 

		Pessoa pessoa1 = new Pessoa(); 


Quando é feito isso, é criado o objeto;

1) dando nome, idade e dando uma funçao para a variavel;
Ex.:	

		pessoa1.Nome = "kayn" //nome
		pessoa1.Idade = 110 //idade
		pessoa1.Apresentar();

*** 

### **Declaracao de tipos de variaveis:**
  
Variavel eh um pedaço da memoria para depois ser usado no programa;

* Ex.: declaramos de tal forma:

	type name = alocando valor
	ex.1: string Apresentacao = "ola, pessoal";
	ex.2: int Quantidade = 1;
	ex.3: double Altura = 1.80;
	ex.4: decimal Preco = 1.80M; (o 'M' eh por causa da sintaxe, o c# avisa para nos colocarmos);
	ex.5: bool Condicao = true;

* Um exemplo de concatenacao: 

		Console.WriteLine(Apresentacao);
		Console.WriteLine(Quantidade);
		Console.WriteLine("Valor da variavel quantidade" + Quantidade);  

* *esse '+' faz o papel de concatenar a frase com a variavel 'Quantidade'

Observação: Variavel so pode ser inicialiazada/declarada apenas uma vez;

Voce so declara quanddo vc coloca o type da variavel, caso contrario ela n sera declarada;

Se vc do colocar o nome da varaivel e nao o  type, ela n sera declarada;

* Ex.1: 

			int Quantidade = 1;
			int Quantidade = 10;
				Esse programa daria erro; 
* Ex.2:
			
			int Quantidade = 1;
			Quantidade = 10;
				Esse programa nao daria erro;

***

### **OPERADOR DE ATRIBUICAO**
Ele serve para vc atribuir um valor ppara uma determinada variavel, passando um sinal de igual;
A variavel so pode ser declarada uma vez, para vc atribuir valor novamente, vc nao pode inicializar a variavel mais deuma vez;

* Ex.: 

		int a = 0;
		int b = 0;
		a = 20;
		b = 10;
		int c = a+b;
		Console.Writeline(c);
		Respostas: 30

***

### **CONVERTENDO TIPOS DE VARIAVEIS**

Imagina a situação na qual eu declaro uma varaivel 'int' e passo o valor em 'string' para ela, o c# avisa que nao pode trabalhar com uma variavel 'int' com valor em 'string';

* Ex.: 

	int a = 5
	Console.WriteLine(a);
	Resposta: 5

Mas se eu colocar:

	int a = "5"
	Console.WriteLine(a);
	Resposta: não é uma operaçao valida

Se vc precisar converter o tipo string para inteiro, isso tem um nome e chama-se "Cast" ou "Casting";

Existem duas formas para fazer isso;

1) Usando a classe Convert.type, em especifico de string para int, essa classe tem o metodo "Toint32()", ficando dessa forma:

* Ex.: 

		int a = Convert.ToInt32("5");
		Console.WriteLine(a);
		Respostas: 5

1) Usando a clase int e o metodo Parse()
   
* Ex.:

		int a = int.Parse("5");
		Console.WriteLine(a);

* Conversao para string:
  
Ex.1:

		string a = "5";
		Console.WriteLine(a);

Mas pode acontecer do valor vir como o type 'int', como fariamos para mudar esse valor para 'string', temos que fazer o processo de 'casting'?

Para converter faça:

* Ex.2: 

		int Valor_Inteiro = 5;
		string a = Valor_Inteiro.ToString();
		Console.WriteLine(a);
***

Explicando o codigo, o 'Valor_Inteiro' pode ter vindo de alguma aplicacao, na qual ele veio com o valor do type 'int';

Passamos essa variavel 'Valor_Inteiro' para uma variavel 'string' chamada de 'a', naqual ela esta convertendo o valor de 'int' para 'string';

E popr final, estamos printando o valor da variavel no terminal;

*Observacao: Tudo tera 'ToString()', pois ela é um metodo da classe mae (que é a maior classe existente no c#, conhecida tbm como classe 'object');*

***

### **CAST IMPLICITO:**
  
Cast Implicito significa que vc vai fazer a conversao, sem utilizar a funcao conversao;

Ex.: 

		int para double;
double é maior que int, entao nao tem problema e o programa nao pede conversao;

***

### **OPERADORES CONDICIONAIS (IF, else, switch, case):**

Operador condicional possibilita mudar o fluxo de execucao de seu codigo, indicando o caminho que ele deve percorrer;

* Operadores condicionais na pratica:

Test: Caso a pessoa compre uma quantidade maior de produtos do que existe no estoque, retornar uma mensagem dizendo que nao tera todos os produtos;

* Ex.:
  
		int QuantidadeEmEstoque = 10;
		int QuantidadeDeCompra = 4;
		if (QuantidadeEmEstoque >= QuantidadeDeCompra)
		{
			Console.WriteLine("Venda realizada");
		}
		else
		{
			Console.WriteLine("Desculpa, nao temos essa quantidade em estoque.");
		}

 ***

* Como debugar o programa
1) deixar clicado com um bola vermelha ao lado esquerdo da linha do programa que vc quer dar o brake
2) aperte F5
3) clique em .NET5

*** 

### **If ANIMADO**

IF aninhado é quando eu tenho um IF dentro de outro IF e Else;

Como usar?

	Primeiro utilize o 'if' com a condiçao que ele precisa;
	Segunda utilize o  'if else' com a segunda condiçao que ele precisa;
	Terceiro utilize  o 'else' com a terceira condiçao que ele precisa;

***

### **APRENDENDO O SWITCH CASE:** 

É utulizado quando tem muitas situações;

* Ex.:

Primeiro vamos fazer um codigo sem estar usando o switch case:

	using ExemploFundamentos.Models;	
	Console.Write("Digite uma letra:");
	string letra = Console.ReadLine();

	if(letra == "a"||letra == "e"||letra=="i"||letra=="o"||letra=="u")
	{
	Console.WriteLine("Vogal");
	}
	else
	{
	Console.WriteLine("Não é uma vogal");
	}

//usando o switch case

	using ExemploFundamentos.Models;	
	Console.Write("Digite uma letra:");
	string letra = Console.ReadLine();

	switch(letra)
	{
	case "a":
	case "e":
	case "i":
	case "o":
	case "u":

		Console.WriteLine("Vogal");
		break;
	default:
		Console.WriteLine("Não é vogal.");
		break;
	}

***

### **INTRODUCAO A OPERADORES LOGICOS**

Sao utilizados principalmente no 'if' para que eu possa realizar uma verificação no meu codigo;

1) operador 'OR' (Pipe, ||), significa `ou`;

Apenas uma condicao precisa ser verdadeira para o 'if' rodar;

Tabela verdade:

			A	B	AvB
			1	1	1
			1	0	1
			0	1	1
			0	0	0

* Ex.:

		using ExemploFundamentos.Models;
		bool ehMaiorDeIdade = false;
		bool possuiAutorizacaoDoResponsavel = true;

		if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
		{
			Console.WriteLine("Entrada Liberada");
		}
		else
		{
			Console.WriteLine("Entrada não Liberada");
		}

2) operador 'AND' (&&), significa `e`;
   
Precisa que as duas ou mais condicoes sejam verdadeiras para o 'if' rodar;

Tabela verdade:

			A	B	AvB
			1	1	1
			1	0	0
			0	1	0
			0	0	0

* Ex.:

		using ExemploFundamentos.Models;
		bool possuiPresencaMinima = true;
		double media = 6.5;

		if (possuiPresencaMinima && media>= 7)
		{
			Console.WriteLine("Aprovado.");
		}
		else
		{
			Console.WriteLine("Reprovado.");
		}

3) operador 'NOT' (!), significa `negacao, ele inverte um valor em bool`;

A condicao que for no sentido de negacao fara o 'if' rodar;

Tabela verdade:

			A	B	AvB (NAND)
			1	1	0
			1	0	1
			0	1	1
			0	0	1

			A	B	AvB (NOR)
			1	1	0
			1	0	0
			0	1	0
			0	0	1

* Ex.:

		using ExemploFundamentos.Models;
		bool choveu = false;
		bool estaTarde = false;

		if (!choveu && !estaTarde)
		{
			Console.WriteLine("Vou pedalar!");
		}
		else
		{
			Console.WriteLine("Não vou pedalar!");
		}

*** 

### **OPERADORES ARITMETICOS**

Sao os operradores matematicos utilizados no c#;

    + : soma
    - : subtracao
    * : multiplicacao
	/ : divisao
	% : resto da divisao
	++ : incremento 
	-- : decremento

***

### **CRRIANDO UMA NOVA CLASSE, A CALCULADORA**

Passo 1: botao direito na pastas model;

passo 2: new c# --> class --> colocar um nome;

passo 3: fazer as funcoes da variavel;;

* Ex.: 

		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Threading.Tasks;

		namespace ExemploFundamentos.Models
		{
   			 public class Calculadora
   		{
        public void Somar(int x, int y) // metodo ou funcao de somar
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
                public void Subtrair (int x, int y) // metodo ou funcao de subtracao
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

passo 4: instanciando/inicializando a variavel;

* ex.: 	primeiro passar o diretorio onde ela se localiza;
  

exemplo: 
		
		using ExemploFundamentos.Models


segundo eh inicializar/instanciar a variavel

exemplo: 

		Calculadora calc = new Calculadora();
		pai 	| objeto filho = novo | classe que ela veio()

		 using ExemploFundamentos.Models;

		Calculadora calc = new Calculadora();

		calc.Somar(10, 30);
		calc.Subtrair(10, 30);
		calc.Multiplicar(10,30);
		calc.Dividir(10,30);

***

*USANDO A CLASSE MATH PARA POTENCIA

Dentro da class:
public void Potencia(int x, int y)

{
double pot = Math.Pow(x,y);
Console.WriteLine($"{x}^{y} = {pot}");
}

No program:

calc.Potencia(10,30);

======================================================================================================================================================================================================================================================================================
*FUNCAO TRIGONOMETRICAS

Ex.:
        public void Seno (double angulo) // metodo de medicao de angulo seno
        {
            double anguloRadiano = angulo * Math.PI / 180; //a funcao Math.Sin so aceita valor em radiano, mas o nosso input eh em angulo, logo pprecisamos transformar nosso input em radiano
            double valorSeno = Math.Sin(anguloRadiano); //funcao seno pelo metodo Math.Sin
            Console.WriteLine($"o valor do seno do angulo {angulo} eh {Math.Round(valorSeno,4)}"); //Print do metodo
        }
        public void Cosseno (double angulo) // metodo de medicao de angulo cosseno
        {
            double anguloRadiano = angulo * Math.PI / 180;
            double valorCosseno = Math.Cos(anguloRadiano);
            Console.WriteLine($"o valor do cosseno do angulo {angulo} eh {Math.Round(valorCosseno,4)}");
        }
        public void Tangente (double angulo) // metodo de medicao de angulo tangente
        {
            double anguloRadiano = angulo * Math.PI / 180;
            double valorTangente = Math.Tan(anguloRadiano);
            Console.WriteLine($"o valor da tangente do angulo {angulo} eh {Math.Round(valorTangente,4)}");
======================================================================================================================================================================================================================================================================================
*REALIZANDO ACAO DE INCREMENTO E DECREMENTO 

//fazendo incremento e decremento de valores com Console.ReadLine

Console.WriteLine($"O valor da variavel eh:");
string numero = Console.ReadLine();
int numeroInteiro = Convert.ToInt32(numero);
numeroInteiro++;
Console.WriteLine($"O valor da variavel +1 eh {numeroInteiro}");
numeroInteiro--;
Console.WriteLine($"O valor da variavel -1 eh {numeroInteiro}");

======================================================================================================================================================================================================================================================================================
*CALCULANDO RAIZ QUADRADA
Ex.:

        public void RaizQuadrada (double variavel)
        {
            double valorRaizQuadrada = Math.Sqrt(variavel);
            Console.WriteLine($"O valor da raiz quadrada de {variavel} = {valorRaizQuadrada}");
        }
======================================================================================================================================================================================================================================================================================
*ESTRUTURA DE REPETICAO

-FOR():

//=============Exemlpos de laços==================

//Laço com for:


//O laco "for" vai ficar repetindo conforme a sua condicao for verdadeira;
//for(1|2|3)
//{

//}
//1-> tipo variavel e o nome da variavel
//2-> condicao para parada
//3-> como a sua variavel vai se comportar dentro do laco

//Exemplo do `for(declaracao da variavel; condicao de parada; o quanto o meu contador ira alterar)` fazenddo uma tabuada;
//Sempre que a condicao do laco for false, ele encerra a repeticao;
//Exemplo: FACA UMA TABOADO DO 5:
//programa:
using ExemploFundamentos.Models;

int numero = 5;

for (int contador = 0; contador<=10; contador++)
{
    Console.WriteLine($"A tabuado do {numero} eh: {numero}x{contador}={numero*contador}");
}

-While():
Encontre uma condicao verdadeira e continue o laco --> while(condicao veradeira);
While nao tem contador, logo a gente precisa gerenciar a contagem;
Uma maneira de quebrar o laco alem da condicao de parada pelo contador eh usando a palavra `break`;
programa:

using ExemploFundamentos.Models;

int numero = 5;
int contador = 0;

while(contador<=10)
{
    Console.WriteLine($"A tabuado do {numero} eh: {numero}x{contador}={numero*contador}");
    contador++;

    if (contador == 6)
    {
        break;
    }
}

-do While():
O 'do' sempre sera feito ai quando chegar no while ele vai ficar procurando a condicao verdadeira para continuar o laco

Ex.:

do{

}while(condicao verdadeira/condicao para continuar);

While nao tem contador, logo a gente precisa gerenciar a contagem;
Uma maneira de quebrar o laco alem da condicao de parada pelo contador eh usando a palavra `break`;
programa:

using ExemploFundamentos.Models;
int soma=0, numero = 0;

do 
{
    Console.WriteLine("Digite um numero (zero para parar o laco):");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;

}while(numero!=0);

Console.WriteLine($"Total da soma eh {soma}");

======================================================================================================================================================================================================================================================================================
*CONSTRUINDO UM MENU INTERATIVO:

Aqui a gente aprende por meio de um exemplo a usar o switch() -- case;

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

//outra maneira de sair do laco do switch case

using ExemploFundamentos.Models;

string opcao;
bool exibirMenu = true;

while(exibirMenu)
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
            exibirMenu=false;//encerrar programa saindo do laco
            break;

        default:
            Console.WriteLine("Opcao nao existente");
            break;
    }
}
======================================================================================================================================================================================================================================================================================
*COMO EU UPAR DIRETORIO NO GIT

1) va  para o diretorio
2) no terminal do git inicie o git --> git init
3) coloque na pasta raiz um arquivo .gitigore conforme a linguagem
4) de no terminal o codigo --> git rm -r --cached .
5) git add --> ele adiciona o git a um commit
6) git commit -m "(escreva aqui o nome do seu commit)" --> eh como se fosse um log
7) crie um repositorio
8) pegue a url do seu repositorio com .git e coloque no terminal do git
9) git push
	9.1) caso preciso fazer a conexao com o git master --> git push -u origin master


git add --> pega as alteracoes para mandar pro commit 
======================================================================================================================================================================================================================================================================================
*ESTRUTURA DE PROJETO E METODO PRINCIPAL

Aqui ira falar quais sao os arquivos principais em .net, como vc pode indentificalos para que eles servem;

-Arquivos de projetos

.csproj: ele contem informacoes referente ao projeto (build, debug, versao);
.sln: eh uma solucao, ele serve para fazer o agrupamento de projetos;

======================================================================================================================================================================================================================================================================================
*CRIANDO UM NOVO PROJETO

1) faça o BK do projeto atual;
2) Va na raiz do diretorio do seu projeto atual;



======================================================================================================================================================================================================================================================================================
*ARRAY E LISTAS:

Array conheciddo tambem como matriz ou vetor, ela eh uma estruturada de dados que armazena valores do mesmo tipo, sempre com um comprimento fixo;
Sao situacoes que vc tera q apresentar diversos valores a uma variavel;
	por exemplo, se vc fosse ppassar os 12 meses do ano, vc nao prpecisa criar 12 variaveis, mas sim criar um arrey que contenha essas 12 variaveis;
Ex.:

1. int[]array = new int[4];
    tipo do array[]nome da variavel = tamanho fixo de array[];
 	
2. int[]array = new int[]{42,75,74,61};
3. string[] nomes = {"Jan","Fev"};

Mas se por exemplo existisse esse array:
	int[]array = new int[]{42,75,74,61};
				0|1 |2 |3

A gente consegue pegar apenas o valor 74, pois ele eh o "indice" 2 do array;
Indice eh o tamanho do array;

Ex. pratico:

using ExemploFundamentos.Common.Models;
using ExemploFundamentos.Models;

int[] arrayInteiros = new int[3]; //total de 3 no indice

arrayInteiros[0] = 72; //--indice 1
arrayInteiros[1] = 64; //--indice 2
arrayInteiros[2] = 50; //--indice 3

//para printar um array faca um laco de repeticao que vao percorrer pelos indices

for(int contador=0; contador < arrayInteiros.Length; contador++)
{
	Console.WriteLine($"Posicao numero {contador} = {arrayInteiros[contador]}");
}


======================================================================================================================================================================================================================================================================================
*TRABALHANDO COM O FOREACH DENTRO DO ARRAY:
O "foreach" so da pra ser usado com o array;

//ARRAY E LISTAS

using ExemploFundamentos.Models;

int[] arrayInteiros = new int[3]; //total de 3 no indice

arrayInteiros[0] = 72; //--indice 1
arrayInteiros[1] = 64; //--indice 2
arrayInteiros[2] = 50; //--indice 3

//para printar um array faca um laco de repeticao que vao percorrer pelos indices
Console.WriteLine("Percorrendo o meu array com o FOR");

for(int contador=0; contador < arrayInteiros.Length; contador++)
{
	Console.WriteLine($"Posicao numero {contador} = {arrayInteiros[contador]}");
}

//Percorrendo o meu array com o FOREACH
Console.WriteLine("Percorrendo o meu array com o FOREACH");
//uma fesvantagem do foreac eh que com ele nao tem como saber em qual indice o array se encontra, a nao ser q vc faca um pprograma com o contador auxiliar
int contadorForeach =0;
foreach (int valorarrayInteiros in arrayInteiros)
{
    Console.WriteLine(valorarrayInteiros);
    //abaixo estara um print para o terminal com o intuito de saber qual indice o foreac se encontra
    contadorForeach++;
    Console.WriteLine($"Posicao numero {contadorForeach} = {valorarrayInteiros}");
}


======================================================================================================================================================================================================================================================================================
*REDIMENSIONANDO UM ARRAY:

//ex.1(FEITO PELO CAIO E NAO PELO PROFESSOR):
using ExemploFundamentos.Models;

int indiceArray=0;

Console.WriteLine("Coloque abaixo o tamanho do seu array:");
indiceArray = Convert.ToInt32(Console.ReadLine());

int[] arrayInteiros = new int[indiceArray];

Console.WriteLine("Percorrendo o meu array com o FOREACH");
//uma vantagem do foreac eh que com ele nao tem como saber em qual indice o array se encontra, a nao ser q vc faca um pprograma com o contador auxiliar
int contadorForeach =0;
foreach (int valorarrayInteiros in arrayInteiros)
{
    Console.WriteLine(valorarrayInteiros);
     //abaixo estara um print para o terminal com o intuito de saber qual indice o foreac se encontra
     contadorForeach++;
     Console.WriteLine($"Posicao numero {contadorForeach} = {valorarrayInteiros}");
}

O professor utilzou a classe Array.Resize --> ela faz uma copia do array que vc passou para ela e comeca mandar as informacoes para la
Ela faz a copia, pois o array nunca pode ter o seu indice mudado apos a inicializacao, logo, o "array nasce e morre com o mesmo tamanho, com a capacidade fixa"

//REDIMENSIONANDDO UTILIZANDO A CLASSE Array.Resize (FEITO PELO PROFESSOR)

using ExemploFundamentos.Models;

int[] arrayInteiros = new int[3]; //total de 3 no indice

arrayInteiros[0] = 72; //--indice 1
arrayInteiros[1] = 64; //--indice 2
arrayInteiros[2] = 50; //--indice 3

int indiceArray=0;
Console.WriteLine("Coloque abaixo o tamanho do seu array:");
indiceArray = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref arrayInteiros, arrayInteiros.Length + indiceArray);
Array.Resize(ref arrayInteiros, arrayInteiros.Length *2);
//para printar um array faca um laco de repeticao que vao percorrer pelos indices
Console.WriteLine("Percorrendo o meu array com o FOR");

for(int contador=0; contador < arrayInteiros.Length; contador++)
{
	Console.WriteLine($"Posicao numero {contador} = {arrayInteiros[contador]}");
}

======================================================================================================================================================================================================================================================================================
*COPIANDO UM ARRAY PARA OUTRO

Primeiro precisamos ter um array que sera copiado e um que sera a copia;
Para copiar usa-se a classe "Array", com o atributo ".Copy";

O metodo ".Copy" funciona e tal meneira, (1,2,3)
	1- array que sera copiado
	2- array que tera a copia
	3- a quantidade de indice que sera copiado

//*PROGRAMA DE COMO COPIAR UM ARRAY
using ExemploFundamentos.Common.Models;
using System;

int[] arrayInteiros = new int[3]; //array qque sera copiado

arrayInteiros[0] = 72; //--indice 1
arrayInteiros[1] = 64; //--indice 2
arrayInteiros[2] = 50; //--indice 3

int[] arrayInterirosCopia = new int[arrayInteiros.Length*2];
Array.Copy(arrayInteiros, arrayInterirosCopia, arrayInteiros.Length);



//para printar um array faca um laco de repeticao que vao percorrer pelos indices
 Console.WriteLine("Percorrendo o meu array com o FOR");

for(int contador=0; contador < arrayInterirosCopia.Length; contador++)
 {
  	Console.WriteLine($"Posicao numero {contador} = {arrayInterirosCopia[contador]}");
 }



======================================================================================================================================================================================================================================================================================
*TRABALHANDO COM UMA LISTA

A lista vc nao precisa gerenciar o tamanho dela;
Ela e como se fosse uma extensao do array, mas vc nao passa o indice;

Maneira de inicializa-la: 
List<string> listaString = new List<string>();

Significado de cada parte da inicializacao da variavel: Classe<Tipo> NomeDaLista = new Classe<Tipo>();

Para adicionar algum dado dentro da lista coloque o metodo ".Add"
Na hora de printar no terminal assim como no array o metodo ".Length" pegava todos os indices do array, ja na lista esse metodo eh o ".Count";

//PROGRAMA CRIANDO UMA LISTA

using ExemploFundamentos.Common.Models;
using System;

List<string> listaString = new List<string>();

listaString.Add("C");
listaString.Add("a");
listaString.Add("i");
listaString.Add("o");

Console.WriteLine("Printando pelo for");
for (int contador = 0; contador < listaString.Count; contador++)
{
	Console.WriteLine($"indice n {contador+1} = dado {listaString[contador]} da lista");
}

Console.WriteLine("Printando pelo foreach");
int contadorForeach = 0;
foreach (string item in listaString)
{
	Console.WriteLine($"indice n {contadorForeach+1} = dado {item} da lista");
	contadorForeach++;
}



======================================================================================================================================================================================================================================================================================
*DESAFIO DE PROGRAMA

Desafio
Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.

Entrada
A entrada consiste em um número inteiro ( n );

Saída
A saída consiste na multiplicação do produto dos dígitos ( n ), a soma de seus dígitos e a diferenção entre o produto e a soma, como no exemplo a baixo: 

Ex.1: entrada 234 - saida 15
Ex.2: entrada 4421 - saida 21

//programa
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
======================================================================================================================================================================================================================================================================================
*INTRODUCAO A PRORIEDADES

E uma maneira flexivel de proteger, ler, gravar ou calcular o valor de um campop particular; 
Resumidamente, a propriedade sao os atributos com limites feitos pelo programador;


