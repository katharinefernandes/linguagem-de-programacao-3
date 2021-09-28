using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Triangulo : Forma
    {
        
            private double b;
            private double altura;

            public Triangulo(double b, double altura)
            {
                Console.WriteLine("-> Triângulo");
                base.setCor("rosa");
                this.b = b;
                this.altura = altura;
                Console.WriteLine("Area do triângulo: " + this.calcularArea());
                Console.WriteLine("\n");
            }

            public Triangulo(double b, double altura, string cor)
            {
                Console.WriteLine("-> Triângulo");
                base.setCor(cor);
                this.b = b;
                this.altura = altura;
                Console.WriteLine("Área do triângulo: " + this.calcularArea());
                Console.WriteLine("\n");
            }

            public override double calcularArea()
            {
                return (b * altura)/2;
            }
    }
}

