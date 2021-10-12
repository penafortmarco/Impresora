using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    class Documento : IImprimible
    {
        public Documento()
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Soy un documento de word");
        }
    }
}
