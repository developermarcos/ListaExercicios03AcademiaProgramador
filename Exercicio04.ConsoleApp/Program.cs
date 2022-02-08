using System;
//• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
//calcule a tabuada de N.
//• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
//10N.

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int[] inicioFimTabuada = { 0, 10 };
            Console.WriteLine("\n-------------------Tabuada-------------------");
            Console.Write("Informe um valor para calcular a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = inicioFimTabuada[0]; i <= inicioFimTabuada[1]; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i.ToString(), numero.ToString(), numero * i);
            }
            Console.ReadKey();
        }
    }
}
