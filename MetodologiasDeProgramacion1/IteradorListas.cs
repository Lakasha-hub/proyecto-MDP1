using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class IteradorListas : Iterador
    {
        protected List<IComparable> lista;
        protected int indice;

        public IteradorListas(List<IComparable> cl)
        {
            this.lista = cl;
            this.indice = 0;
        }

        public IComparable Actual() { return this.lista[indice]; }

        public void Siguiente() { indice++; }

        public bool Fin() { return indice >= this.lista.Count; }
    }
}
