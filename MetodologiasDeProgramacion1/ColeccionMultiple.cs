using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class ColeccionMultiple : IColeccionable
    {
        protected Pila pila;
        protected Cola cola;
        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }
        public int Cuantos() { return pila.Cuantos() + cola.Cuantos(); }
        public IComparable Minimo()
        {
            IComparable minCola = cola.Minimo();
            IComparable minPila = pila.Minimo();

            // Solución temporal, puede devolver excepción en caso de que sean iguales
            return minCola.SosMenor(minPila) ? minCola : minPila;
        }
        public IComparable Maximo()
        {
            IComparable maxCola = cola.Maximo();
            IComparable maxPila = pila.Maximo();

            // Solución temporal, puede devolver excepción en caso de que sean iguales
            return maxCola.SosMayor(maxPila) ? maxCola : maxPila;
        }
        public void Agregar(IComparable cm) { }
        public bool Contiene(IComparable cm) { return cola.Contiene(cm) || pila.Contiene(cm); }

    }
}
