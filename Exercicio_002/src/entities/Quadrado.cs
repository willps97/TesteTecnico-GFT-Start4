using System;
using Exercicio_002.src.interfaces;


namespace Exercicio_002.src.entities
{
    class Quadrado : ICalculoGerais
    {
        public double Area { get; set; }
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public double CalculodeArea()
        {
            Area = Math.Pow(Lado, 2);
            return Area;

        }
    }
}
