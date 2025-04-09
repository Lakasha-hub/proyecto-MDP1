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
        protected IEstrategiaComparacion estrategia;

        public Alumno(string n, int d, int l, int p, IEstrategiaComparacion e) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = e;
        }

        public int GetLegajo() { return this.legajo; }

        public int GetPromedio() { return this.promedio; }

        public void SetEstrategia(IEstrategiaComparacion es) { this.estrategia = es; }

        public override string ToString() { return $"Alumno: {GetNombre()} | DNI: {GetDni()} | Promedio: {GetPromedio()} | Legajo: {GetLegajo()}"; }

        public override bool SosIgual(IComparable cm) { return this.estrategia.Igual(this, cm); }
        public override bool SosMenor(IComparable cm) { return this.estrategia.Menor(this, cm); }
        public override bool SosMayor(IComparable cm) { return this.estrategia.Mayor(this, cm); }
    }
}
