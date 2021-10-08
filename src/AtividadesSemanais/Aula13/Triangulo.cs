using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Triangulo : IForma
    {
        private double b;
        private double altura;

        public Triangulo(double b, double altura)
        {
            Console.WriteLine("-> Triângulo");
            this.b = b;
            this.altura = altura;
        }
        public double calcularArea()
        {
            return (this.b * this.altura) / 2;
        }
    }
}

