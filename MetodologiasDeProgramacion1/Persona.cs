using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal abstract class Persona : IComparable
    {
        protected string nombre;
        protected int dni;
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public string GetNombre() { return this.nombre; }
        public int GetDni() { return this.dni; }
        public abstract bool SosIgual(IComparable cm);
        public abstract bool SosMenor(IComparable cm);
        public abstract bool SosMayor(IComparable cm);
    }
}
