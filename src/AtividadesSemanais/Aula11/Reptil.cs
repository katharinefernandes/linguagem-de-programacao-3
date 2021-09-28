using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.Locomocao();
        }

        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Reptil");
        }
    }
}