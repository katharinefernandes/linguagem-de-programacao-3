using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            
        }
        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Cachorro");
            Console.WriteLine(" -- Cachorros: São quadrúpedes, se locomovem apoiando-se nas patas dianteiras e traseiras.\n\n");
        }
    }
}
