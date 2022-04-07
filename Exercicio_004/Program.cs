using System;

/*Escreva um programa que receba um valor entre 3 e 999 como
entrada e apresente, quais números nesse intervalo são primos
entre si*/

namespace Exercicio_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número entre 3 e 999 para saber seus primos: ");
            int n = int.Parse(Console.ReadLine());
            bool primo  = true;

            while (n <= 3 && n >= 999)
            {
                Console.WriteLine("Número inválido");
                Console.WriteLine("Digite um número entre 3 e 999 para saber seus primos: ");
                n = int.Parse(Console.ReadLine());
            }

            for ( int i = 2; i< n; i++)
            {
                if ( i % 2 == 0 && i / i == 1)
                {
                    Console.Write("Primos : " + i + " ");
                }
            }
           

        }
    }
}
