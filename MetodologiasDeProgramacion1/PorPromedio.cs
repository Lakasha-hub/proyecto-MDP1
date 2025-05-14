using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorPromedio : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetPromedio() == ((IAlumno)cm2).GetPromedio(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetPromedio() < ((IAlumno)cm2).GetPromedio(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetPromedio() > ((IAlumno)cm2).GetPromedio(); }
    }
}
