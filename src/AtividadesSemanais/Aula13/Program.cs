using System;

namespace Aula13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Area da forma: " + forma.calcularArea());
        }

        static void Main(string[] args)
        {
            IForma forma = new Quadrado(10.0);
            mostrarArea(forma);

            forma = new Retangulo(5.0, 7.5);
            mostrarArea(forma);

            forma = new Circulo(4.0);
            mostrarArea(forma);

            forma = new Triangulo(2.0, 6.5);
            mostrarArea(forma);

        }
    }
}
