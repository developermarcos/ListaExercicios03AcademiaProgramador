using System;
//Desenvolver um algoritmo que efetue a soma de todos os números
//ímpares que são múltiplos de três e que se encontram no conjunto dos
//números de 1 até 500.
namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somador = 0;
            for (int i = 0; i < 501; i++)
            {
                if (i % 2 != 0 && i %3 == 0)
                {
                    somador += i;
                }
            }
            Console.WriteLine(somador.ToString());
            Console.ReadKey();
        }
    }
}
