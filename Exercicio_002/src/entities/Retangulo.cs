using System;
using Exercicio_002.src.interfaces;

namespace Exercicio_002.src.entities
{
    class Retangulo : ICalculoGerais
    {
        public double Area { get; set; }
        public double Base{ get; set; }
        public double Altura { get; set; }

        public Retangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double CalculodeArea()
        {
            Area = Base * Altura;

            return Area;
        }
    }
}
