using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorLegajo : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetLegajo() == ((IAlumno)cm2).GetAlumno().GetLegajo(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetLegajo() < ((IAlumno)cm2).GetAlumno().GetLegajo(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetLegajo() > ((IAlumno)cm2).GetAlumno().GetLegajo(); }
    }
}
