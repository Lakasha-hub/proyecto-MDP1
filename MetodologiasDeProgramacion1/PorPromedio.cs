using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorPromedio : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetPromedio() == ((IAlumno)cm2).GetAlumno().GetPromedio(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetPromedio() < ((IAlumno)cm2).GetAlumno().GetPromedio(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetPromedio() > ((IAlumno)cm2).GetAlumno().GetPromedio(); }
    }
}
