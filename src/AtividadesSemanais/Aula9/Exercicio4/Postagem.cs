using System;

namespace Exercicio4
{
    class Postagem
    {
        private string titulo;
        private string data;
        private string conteudo;
        private int visitas;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Data { get => data; set => data = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }
        public int Visitas { get => visitas; set => visitas = value; }
    }
}
