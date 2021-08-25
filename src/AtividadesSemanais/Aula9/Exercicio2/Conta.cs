using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Conta
    {
        private string agencia;
        private int numero;
        private float saldo;

        public string Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
}