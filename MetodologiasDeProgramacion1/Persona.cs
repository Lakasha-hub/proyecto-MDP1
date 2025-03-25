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
        public virtual bool SosIgual(IComparable cm) { return GetDni() == ((Persona)cm).GetDni(); }
        public virtual bool SosMenor(IComparable cm) { return GetDni() < ((Persona)cm).GetDni(); }
        public virtual bool SosMayor(IComparable cm) { return GetDni() > ((Persona)cm).GetDni(); }
    }
}
