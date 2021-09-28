using System;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo(8.5);
            Circulo circ2 = new Circulo(4.0, "verde");
            Quadrado quad1 = new Quadrado(15.0);
            Quadrado quad2 = new Quadrado(10.0, "vermelho");
            Retangulo retang1 = new Retangulo(10.0, 5.0);
            Retangulo retang2 = new Retangulo(15.5, 5.5, "laranja");
            Triangulo triang1 = new Triangulo(8.0, 6.0);
            Triangulo triang2 = new Triangulo(6.0, 4.0, "azul");

        }
    }
}
