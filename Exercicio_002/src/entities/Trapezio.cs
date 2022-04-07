using System;
using Exercicio_002.src.interfaces;


namespace Exercicio_002.src.entities
{
    class Trapezio : ICalculoGerais
    {
        public double Area { get; set; }
        public double BaseMaior { get; set; }
        public double BaseMenor{ get; set; }
        public double Altura { get; set; }

        public Trapezio(double baseMaior, double baseMenor, double altura)
        {
            BaseMaior = baseMaior;
            BaseMenor = baseMenor;
            Altura = altura;
        }

        public double CalculodeArea()
        {
            Area = ((BaseMaior + BaseMenor) * Altura) / 2;
            return Area;
        }
    }
}
