using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Conjunto : IColeccionable, Iterable
    {
        List<IComparable> lista;

        public Conjunto()
        {
            this.lista = [];
        }

        public int Cuantos() { return this.lista.Count; }

        public IComparable Minimo()
        {
            IComparable min = this.lista[0];
            for (int i = 1; i < Cuantos(); i++)
            {
                if (this.lista[i].SosMenor(min))
                    min = this.lista[i];
            }
            return min;
        }

        public IComparable Maximo()
        {
            IComparable max = this.lista[0];
            for (int i = 1; i < Cuantos(); i++)
            {
                if (this.lista[i].SosMayor(max))
                    max = this.lista[i];
            }
            return max;
        }

        public void Agregar(IComparable cm)
        {
            if (!Pertenece(cm))
            {
                this.lista.Add(cm);
                return;
            }

            Console.WriteLine("El elemento ya se encuentra en el conjunto.");
        }

        private bool Pertenece(IComparable cm)
        {
            for (int i = 0; i < Cuantos(); i++)
            {
                if (cm.SosIgual(this.lista[i]))
                    return true;
            }
            return false;
        }

        public bool Contiene(IComparable cm) { return Pertenece(cm); }

        public IteradorListas CrearIterador() { return new IteradorListas(this.lista); }
    }
}
