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
        
        public override string ToString() { return $"Alumno: {GetNombre()} | DNI: {GetDni()} | Promedio: {GetPromedio()} | Legajo: {GetLegajo()}"; }

        //Comparacion usando promedios
        public override bool SosIgual(IComparable cm) { return GetPromedio() == ((Alumno)cm).GetPromedio(); }
        public override bool SosMenor(IComparable cm) { return GetPromedio() < ((Alumno)cm).GetPromedio(); }
        public override bool SosMayor(IComparable cm) { return GetPromedio() > ((Alumno)cm).GetPromedio(); }
    }
}
