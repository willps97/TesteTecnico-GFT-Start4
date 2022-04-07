using System;
using System.Globalization;
using Exercicio_002.src.entities;

/*Escreva um programa que contenha uma interface chamada
calculosGerais. Essa interface deve conter um único método
chamado calculoDeArea. Crie também quatro classes que deverão
implementar a interface calculosGerais. As classes serão
Triangulo, Retangulo, Quadrado e Trapezio. O programa deverá
imprimir a área de cada uma das figuras geométricas
apresentadas abaixo*/

namespace Exercicio_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite o nome de qual figura geométrica deseja calcular a área. ");
            Console.WriteLine("triangulo, retângulo, quadrado, trapezio. Caso deseje sair, digite x");
            string verificador = Console.ReadLine().ToLower();
            
            while(verificador != "x")
            {
                switch (verificador)
                {
                    case "triangulo":
                        Console.Write("Digite a base do triângulo: ");
                        double baseTriangulo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        Console.Write("Digite a altura do triângulo: ");
                        double alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Triangulo triangulo = new Triangulo(baseTriangulo,alturaTriangulo);
                        Console.WriteLine("A Area do triângulo é de: " + triangulo.CalculodeArea().ToString("F2",CultureInfo.InvariantCulture));
                        break;

                    case "retangulo":
                        Console.Write("Digite a base do retângulo: ");
                        double baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Digite a altura do retângulo: ");
                        double alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);
                        Console.WriteLine("A Area do retângulo é de: " + retangulo.CalculodeArea().ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case "quadrado":
                        Console.Write("Digite o lado do Quadrado: ");
                        double ladoQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Quadrado quadrado = new Quadrado(ladoQuadrado);
                        Console.WriteLine("A Area do quadrado é de: " + quadrado.CalculodeArea().ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    case "trapezio":
                        Console.Write("Digite a base maior do trapézio: ");
                        double ladoMaior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Digite a base menor do trapézio: ");
                        double ladoMenor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Digite a altura do trapézio: ");
                        double alturaTrapezio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Trapezio trapezio = new Trapezio(ladoMaior, ladoMenor, alturaTrapezio);
                        Console.WriteLine("A Area do trapézio é de: " + trapezio.CalculodeArea().ToString("F2", CultureInfo.InvariantCulture));
                        break;

                    default:
                        Console.WriteLine("Valor inválido!");
                        break;
                }
            }


        }
    }
}
