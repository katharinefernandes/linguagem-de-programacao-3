using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            this.Locomocao();
        }

        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Mamífero");
        }
    }
}
