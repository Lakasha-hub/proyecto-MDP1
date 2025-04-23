using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorAntiguedad : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((Profesor)cm).GetAntiguedad() == ((Profesor)cm2).GetAntiguedad(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((Profesor)cm).GetAntiguedad() < ((Profesor)cm2).GetAntiguedad(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((Profesor)cm).GetAntiguedad() > ((Profesor)cm2).GetAntiguedad(); }
    }
}
