using System;

namespace Aula8
{
	public class Program
	{
		public static void Main()
		{
			Casa casa = new Casa();
			Casa casa2 = new Casa();

			casa.Area = 225F;
			casa.Altura = 20F;
			casa.Preco = 500000.00m;

			casa2.Area = 500F;
			casa2.Altura = 40F;
			casa2.Preco = 1000000.00m;

			Console.WriteLine("--- Casa 1 ---");
			Console.WriteLine("Area: " + casa.Area);
			Console.WriteLine("Altura: " + casa.Altura);
			Console.WriteLine("Preco: " + casa.Preco);

			Console.WriteLine("--- Casa 2 ---");
			Console.WriteLine("Area: " + casa.Area);
			Console.WriteLine("Altura: " + casa.Altura);
			Console.WriteLine("Preco: " + casa.Preco);
		}
	}
}