using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Cliente
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private Conta conta;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public Conta Conta
        {
            get { return conta; }
            set { conta = value; }
        }

    }
}