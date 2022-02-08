using System;
//• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
//valores do cálculo de A! e o seu resultado.
//Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
//• Pesquise sobre “fatorial”
namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, resultado = 1;
            string apresentacao = "";

            Console.Write("Informe um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());   
            for (int i = numero; i > 0; i--)
            {
                if(i > 1)
                {
                    apresentacao += i.ToString()+" x ";
                }
                else
                {
                    apresentacao += i.ToString();
                }
                resultado *= i;
            }
            Console.Write("{0}! = {1} = {2}", numero.ToString(), apresentacao , resultado.ToString());
            Console.ReadKey();
        }
    }
}
