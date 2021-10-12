using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    class Contrato : IImprimible
    {
        public Contrato()
        {
        }

        public void Imprimir()
    {
            Console.WriteLine("Soy un contrato muy legal");
    }

    }
}
