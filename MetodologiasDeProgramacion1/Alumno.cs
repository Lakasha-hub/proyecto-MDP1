using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Alumno : Persona
    {
        protected int legajo;
        protected int promedio;

        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int GetLegajo() { return this.legajo; }

        public int GetPromedio() { return this.promedio; }
    }
}
