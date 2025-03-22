using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Pila : IColeccionable
    {
        protected List<IComparable> lista;

        public Pila()
        {
            this.lista = [];
        }

        private void Apilar(IComparable cm) => lista.Add(cm);

        public IComparable Desapilar()
        {
            IComparable aux = this.lista[Cuantos() - 1];
            this.lista.RemoveAt(Cuantos() - 1);
            return aux;
        }

        public int Cuantos() { return this.lista.Count; }

        public IComparable Minimo() {
            IComparable min = this.lista[0];
            for (int i = 1; i < Cuantos(); i++)
            {
                if (this.lista[i].SosMenor(min))
                {
                    min = this.lista[i];
                }
            }
            return min;
        }

        public IComparable Maximo() {
            IComparable max = this.lista[0];
            for (int i = 1; i < Cuantos(); i++)
            {
                if (this.lista[i].SosMayor(max))
                {
                    max = this.lista[i];
                }
            }
            return max;
        }

        public void Agregar(IComparable cm) => Apilar(cm);

        public bool Contiene(IComparable cm) {
            for (int i = 0; i < Cuantos(); i++)
            {
                if (cm.SosIgual(this.lista[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
