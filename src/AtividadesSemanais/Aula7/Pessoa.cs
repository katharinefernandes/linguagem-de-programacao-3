using System;
using System.Collections.Generic;
using System.Text;

namespace Aula7 { 
    public class Program
    {
        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            Console.WriteLine("--- Seus dados de Cadastro ---");
            Console.WriteLine("Nome: " + p1.getNome());
            Console.WriteLine("Sobrenome: " + p1.getSobrenome());
            Console.WriteLine("Idade: " + p1.getIdade());
            Console.WriteLine("Altura: " + p1.getAltura());
            Console.WriteLine("Peso: " + p1.getPeso());
        }
    }
}
