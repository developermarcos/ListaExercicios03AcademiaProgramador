using System;
//• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
//programa deverá calcular e mostrar:
//a.A menor altura do grupo;
//b.A maior altura do grupo;
namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double menorAltura = 0, maiorAltura = 0, altura;
            const int quantidadePessoasTurma = 15;

            Console.WriteLine("Sistema para informar o maior e a menor altura da turma");
            for (int i = 0; i < quantidadePessoasTurma; i++)
            {
                Console.Write("Informe a altura da turma da {0}ª pessoa: ", i+1);
                altura = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    menorAltura = altura;
                    maiorAltura = altura;
                }
                else
                {
                    menorAltura = menorAltura > altura ? altura : menorAltura;
                    maiorAltura = maiorAltura < altura ? altura : maiorAltura;
                }
            }
            Console.WriteLine("A maior altura foi: {0} e a menor altura foi: {1}", maiorAltura.ToString(), menorAltura.ToString());

            Console.ReadKey();
        }
    }
}
