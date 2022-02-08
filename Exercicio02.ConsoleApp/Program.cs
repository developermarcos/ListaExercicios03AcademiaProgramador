using System;
//Escrever um algoritmo que gera e escreve os números ímpares entre 100
//e 200.
namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", i.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
