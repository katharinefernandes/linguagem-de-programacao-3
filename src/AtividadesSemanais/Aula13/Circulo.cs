using System;

namespace Aula13
{
    class Circulo : IForma
    {
        private double raio;
        public Circulo(double raio)
        {
            Console.WriteLine("-> Círculo");
            this.raio = raio;
        }

        public double calcularArea()
        {
            return (3.14 * (this.raio * this.raio));
        }
    }
}
