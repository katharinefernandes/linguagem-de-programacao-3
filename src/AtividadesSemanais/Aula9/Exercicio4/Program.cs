using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Postagem p1 = new Postagem();
            p1.Titulo = "Et Bilu - O blog";
            p1.Data = "20/06/2021";
            p1.Conteudo = "Um olá para a Terra";
            p1.Visitas = 15;

            Postagem p2 = new Postagem();
            p2.Titulo = "O retorno do ET Bilu";
            p2.Data = "30/06/2021";
            p2.Conteudo = "O ET Bilú é uma suposta criatura humanoide com uma voz parecida com a de uma criança...";
            p2.Visitas = 100;

            Postagem p3 = new Postagem();
            p3.Titulo = "Busquem conhecimento amigos da Terra";
            p3.Data = "09/07/2021";
            p3.Conteudo = "Busquem conhecimento, disse o personagem que ficou conhecido como ET Bilu, vídeo que virou fenômeno na internet...";
            p3.Visitas = 250;

            Usuario us1 = new Usuario();
            us1.Nome = "Katharine";
            us1.Sobrenome = "Fernandes";
            us1.Senha = "AbCd123?";
            us1.Postagens[0] = p1;
            us1.Postagens[1] = p2;
            us1.Postagens[2] = p3;

            Console.WriteLine("-- Informações do Usuário --");
            Console.WriteLine("Nome: " + us1.Nome);
            Console.WriteLine("Sobrenome: " + us1.Sobrenome);

            Console.WriteLine("\n\n---- Postagens ----");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Titulo da publicação " + (i + 1) + ": " + us1.Postagens[i].Titulo);
                Console.WriteLine("Data da publicação " + (i + 1) + ": " + us1.Postagens[i].Data);
                Console.WriteLine("Conteúdo da publicação " + (i + 1) + ": " + us1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas da publicação " + (i + 1) + ": " + us1.Postagens[i].Visitas + "\n\n");
            }

        }
     }
}

