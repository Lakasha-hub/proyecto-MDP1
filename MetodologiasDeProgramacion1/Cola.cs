using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Cola : IColeccionable, Iterable, IOrdenable
    {
        protected List<IComparable> lista;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula1 ordenAulaLlena;
        private IOrdenEnAula2 ordenNuevoAlumno;

        public Cola()
        {
            this.lista = [];
        }

        private void Encolar(IComparable cm)
        {
            if (Cuantos() == 0)
                ordenInicio.Ejecutar();

            lista.Add(cm);
            ordenNuevoAlumno.Ejecutar(cm);

            if (Cuantos() == 40)
                ordenAulaLlena.Ejecutar();
        }

        public IComparable Desencolar()
        {
            IComparable aux = this.lista[0];
            this.lista.RemoveAt(0);
            return aux;
        }

        public int Cuantos() { return this.lista.Count; }

        public IComparable Minimo()
        {
            IComparable min = this.lista[0];
            for(int i = 1; i < Cuantos(); i++)
            {
                if (this.lista[i].SosMenor(min))
                {
                    min = this.lista[i];
                } 
            }
            return min;
        }

        public IComparable Maximo()
        {
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

        public void Agregar(IComparable cm) => Encolar(cm);

        public bool Contiene(IComparable cm)
        {
            for(int i = 0; i < Cuantos(); i++)
            {
                if (cm.SosIgual(this.lista[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public IteradorListas CrearIterador() { return new IteradorListas(this.lista); }

        public void SetOrdenInicio(IOrdenEnAula1 orden) { this.ordenInicio = orden; }
        public void SetOrdenLlegaAlumno(IOrdenEnAula2 orden) { this.ordenNuevoAlumno = orden; }
        public void SetOrdenAulaLlena(IOrdenEnAula1 orden) { this.ordenAulaLlena = orden; }
    }
}
