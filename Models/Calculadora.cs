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

        public void Multiplicar (int x, int y) // metodo ou funcao de multiplicacao
        {
            Console.WriteLine($"{x} * {y} = {x*y}");
        }

        public void Dividir (int x, int y) // metodo ou funcao de divisao
        {
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia (int variavel1, int variavel2) //metodo de poptenciacao
        {
            double pot = Math.Pow(variavel1,variavel2);
            Console.WriteLine($"{variavel1}^{variavel2} = {pot}");
        }
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
        }
        public void RaizQuadrada (double variavel)
        {
            double valorRaizQuadrada = Math.Sqrt(variavel);
            Console.WriteLine($"O valor da raiz quadrada de {variavel} = {valorRaizQuadrada}");
        }
    }
}