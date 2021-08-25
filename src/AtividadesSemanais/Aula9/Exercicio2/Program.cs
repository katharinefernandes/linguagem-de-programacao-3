using System;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            Conta ct1 = new Conta();
            
            c1.Nome = "Isabelle";
            c1.Sobrenome = "Nascimento";
            c1.Cpf = "234.567.879-12";
            c1.Conta = ct1;

            ct1.Agencia = "1052";
            ct1.Numero = 123456;
            ct1.Saldo = 1000000000.00F;

            Cliente c2 = new Cliente();
            Conta ct2 = new Conta();

            c2.Nome = "Larissa";
            c2.Sobrenome = "Souza";
            c2.Cpf = "432.765.123-34";
            c2.Conta = ct2;

            ct2.Agencia = "2056";
            ct2.Numero = 205612;
            ct2.Saldo = 245100500.00F;

            Cliente c3 = new Cliente();
            Conta ct3 = new Conta();

            c3.Nome = "Pedro";
            c3.Sobrenome = "Eleutério";
            c3.Cpf = "656.873.123-65";
            c3.Conta = ct3;
            
            ct3.Agencia = "2036";
            ct3.Numero = 207645;
            ct3.Saldo = 765300000.00F;

            Console.WriteLine("\n Informações do Cliente 1\n\n");
            Console.WriteLine("Nome: " + c1.Nome);
            Console.WriteLine("Sobrenome: " + c1.Sobrenome);
            Console.WriteLine("Cpf: " + c1.Cpf);

            Console.WriteLine("\n Conta do Cliente 1 \n\n");
            Console.WriteLine("Agencia: " + ct1.Agencia);
            Console.WriteLine("Número: " + ct1.Numero);
            Console.WriteLine("Saldo: " + ct1.Saldo);

            Console.WriteLine("\n Informações do Cliente 2\n\n");
            Console.WriteLine("Nome: " + c2.Nome);
            Console.WriteLine("Sobrenome: " + c2.Sobrenome);
            Console.WriteLine("Cpf: " + c2.Cpf);

            Console.WriteLine("\n Conta do Cliente 2 \n\n");
            Console.WriteLine("Agencia: " + ct2.Agencia);
            Console.WriteLine("Número: " + ct2.Numero);
            Console.WriteLine("Saldo: " + ct2.Saldo);
            
            Console.WriteLine("\n Informações do Cliente 3\n\n");
            Console.WriteLine("Nome: " + c3.Nome);
            Console.WriteLine("Sobrenome: " + c3.Sobrenome);
            Console.WriteLine("Cpf: " + c3.Cpf);
            
            Console.WriteLine("\n Conta do Cliente 3 \n\n");
            Console.WriteLine("Agencia: " + ct3.Agencia);
            Console.WriteLine("Número: " + ct3.Numero);
            Console.WriteLine("Saldo: " + ct3.Saldo);
            
        }

    }
}

