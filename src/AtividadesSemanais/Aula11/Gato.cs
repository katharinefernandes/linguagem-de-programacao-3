using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Gato : Mamifero
    {
        public Gato()
        {
            
        }
        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Gato");
            Console.Write(" -- Gatos: São quadrúpedes, o que quer dizer que se locomovem apoiando-se nas patas dianteiras e traseiras.\n\n");
        }
    }
}
