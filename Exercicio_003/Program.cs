using System;
using Exercicio_003.src.Entities;
/*Crie um programa que contenha uma classe Pessoa e uma classe
Cachorro. A classe Pessoa deverá ter os seguintes atributos:
nomePessoa, idadePessoa, e pet (que será um objeto Cachorro). A
classe Cachorro terá os seguintes atributos: raca, porte e
idade.*/


namespace Exercicio_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite as informações abaixo.");
            Console.Write("Seu nome: ");
            string nomeHumano = Console.ReadLine();
            Console.Write("Seu nome: ");
            int idadeHumano = int.Parse(Console.ReadLine());
            Console.Write("Nome do seu pet: ");
            string nomePet = Console.ReadLine();
            Console.Write("Porte do seu Pet: ");
            string portePet = Console.ReadLine().ToLower();
            Console.Write("Idade do seu Pet: ");
            int idadePet = int.Parse(Console.ReadLine());
            int idadePetHumano;
            int diferenca;


            Pessoa pessoa = new Pessoa();

            if (portePet == "pequeno")
            {
                idadePetHumano = idadePet * 12;
                diferenca = idadePetHumano - idadeHumano;

                Console.WriteLine($"A idade humana do {nomePet} é { idadeHumano} anos. E a diferença de idade entre o pet e seu dono é de: {diferenca} anos.");
            }
            if (portePet == "medio")
            {
                idadePetHumano = idadePet * 10;
                diferenca = idadePetHumano - idadeHumano;

                Console.WriteLine($"A idade humana do {nomePet} é { idadeHumano} anos. E a diferença de idade entre o pet e seu dono é de: {diferenca} anos.");
            }
            if (portePet == "grande")
            {
                idadePetHumano = idadePet * 9;
                diferenca = idadePetHumano - idadeHumano;

                Console.WriteLine($"A idade humana do {nomePet} é { idadeHumano} anos. E a diferença de idade entre o pet e seu dono é de: {diferenca} anos.");
            }







        }
    }
}
