using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            
        }
        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Sapo");
            Console.WriteLine(" -- Sapos:  Locomovem-se preferencialmente aos pulos, mas podem também marchar, como que engatinhando.\n\n");
        }
    }
}
