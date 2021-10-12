using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresora
{
    class Impresora
    {
        List<IImprimible> listaImprimibles = new List<IImprimible>();
        
        public void imprimirTodo()
        {
            foreach (IImprimible i in listaImprimibles)
            {
                i.Imprimir();
            }   
        } 
        public void agregarImprimible()
        {
            listaImprimibles.Add(new Documento());
            listaImprimibles.Add(new Foto());
            listaImprimibles.Add(new Contrato());
        }
    }
}
