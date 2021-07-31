using System;

namespace Aula7
{
    public class Pessoa
    {
        private string nome = "Katharine";
        private string sobrenome = "Fernandes";
        private byte idade = 17;
        private float altura = 1.7F;
        private float peso = 55.5F;

        //acessando atributos privados
        public string getNome()
        {
            return this.nome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public byte getIdade()
        {
            return this.idade;
        }
        public float getAltura()
        {
            return this.altura;
        }
        public float getPeso()
        {
            return this.peso;
        }
    }
}