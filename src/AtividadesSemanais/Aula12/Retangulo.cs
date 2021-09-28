using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Retangulo : Forma
    {
        private double lado1;
        private double lado2;
        public Retangulo(double lado1, double lado2)
        {
            Console.WriteLine("-> Retângulo");
            base.setCor("roxo");
            this.lado1 = lado1;
            this.lado2 = lado2;
            Console.WriteLine("Area do retângulo: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public Retangulo(double lado1, double lado2, string cor)
        {
            Console.WriteLine("-> Retângulo");
            base.setCor(cor);
            this.lado1 = lado1;
            this.lado2 = lado2;
            Console.WriteLine("Area do retângulo: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public override double calcularArea()
        {
            return lado1 * lado2;
        }

    }
}

