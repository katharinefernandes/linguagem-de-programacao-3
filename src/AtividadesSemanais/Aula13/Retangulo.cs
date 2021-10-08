using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13
{
    class Retangulo : IForma
    {
        private double altura;
        private double largura;
        public Retangulo(double altura, double largura)
        {
            Console.WriteLine("-> Retângulo");
            this.altura = altura;
            this.largura = largura;
        }

        public double calcularArea()
        {
            return this.altura * this.largura;
        }
    }
}

