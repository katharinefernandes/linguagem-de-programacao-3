using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            
        }
        protected override void Locomocao()
        {
            base.Locomocao();
            Console.WriteLine(" -> Jacare");
            Console.WriteLine(" -- Jacares: São excelentes nadadores, permanecendo com as patas próximas ao corpo enquanto ondulam lateralmente o corpo e a cauda para se locomover. Em terra também são muito rápidos, andando com a barriga levantada e as patas sob o corpo.\n\n");
        }
    }
}
