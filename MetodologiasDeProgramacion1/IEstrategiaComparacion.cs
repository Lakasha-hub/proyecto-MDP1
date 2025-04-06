using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal interface IEstrategiaComparacion
    {
        bool Igual(IComparable cm, IComparable cm2);
        bool Menor(IComparable cm, IComparable cm2);
        bool Mayor(IComparable cm, IComparable cm2);
    }
}
