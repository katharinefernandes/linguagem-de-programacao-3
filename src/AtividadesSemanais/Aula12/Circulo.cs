using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            Console.WriteLine("-> Círculo");
            base.setCor("amarelo");
            this.raio = raio;
            Console.WriteLine("Area do círculo: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public Circulo(double raio, string cor)
        {
            Console.WriteLine("-> Círculo");
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Area do círculo: " + this.calcularArea());
            Console.WriteLine("\n");
        }

        public override double calcularArea()
        {
            return (3.14 * (raio * raio));
        }
    }
}
