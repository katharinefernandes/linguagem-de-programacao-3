using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            Console.WriteLine("-> Quadrado");
            base.setCor("azul");
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public Quadrado(double lado, string cor)
        {
            Console.WriteLine("-> Quadrado");
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public override double calcularArea()
        {
            return lado * lado;
        }

    }
}
