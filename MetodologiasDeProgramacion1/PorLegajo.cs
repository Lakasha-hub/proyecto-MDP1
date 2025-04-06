using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorLegajo : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetLegajo() == ((Alumno)cm2).GetLegajo(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetLegajo() < ((Alumno)cm2).GetLegajo(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetLegajo() > ((Alumno)cm2).GetLegajo(); }
    }
}
