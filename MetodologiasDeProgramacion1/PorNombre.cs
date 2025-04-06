using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorNombre : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetNombre() == ((Alumno)cm2).GetNombre(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetNombre().Length < ((Alumno)cm2).GetNombre().Length; }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((Alumno)cm).GetNombre().Length > ((Alumno)cm2).GetNombre().Length; }
    }
}
