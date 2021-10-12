using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    class Foto : IImprimible
    {
        public Foto()
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Soy una selfie pal insta");
        }
    }
}
