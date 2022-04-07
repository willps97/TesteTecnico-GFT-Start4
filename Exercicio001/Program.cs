using System;

/*Escreva um programa que receba a data de nascimento de duas 
 * pessoas e imprima quantos dias vividos a pessoa mais velha tem em relação a mais nova*/

namespace Exercicio001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a data de nascimento da pessoa mais velha. (DD/mm/yyyy): ");
            DateTime dtNascOld = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite a data de nascimento da pessoa mais nova. (DD/mm/yyyy): ");
            DateTime dtNascYoung = DateTime.Parse(Console.ReadLine());

            int diferenca = (dtNascYoung.Year - dtNascOld.Year) * 365;
            Console.WriteLine($"A pessoa mais velha viveu {diferenca} dias a mais do que a pessoa mais nova.");
        }
    }
}
