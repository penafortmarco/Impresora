using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora i1 = new Impresora();

            i1.agregarImprimible();
            i1.imprimirTodo();
            Console.ReadKey();
        }
    }
}
