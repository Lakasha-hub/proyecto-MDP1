using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorNombre : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetNombre() == ((IAlumno)cm2).GetAlumno().GetNombre(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetNombre().Length < ((IAlumno)cm2).GetAlumno().GetNombre().Length; }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetNombre().Length > ((IAlumno)cm2).GetAlumno().GetNombre().Length; }
    }
}
