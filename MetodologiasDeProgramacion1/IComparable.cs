using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    public interface IComparable
    {
        bool SosIgual(IComparable cm);
        bool SosMenor(IComparable cm);
        bool SosMayor(IComparable cm);
    }


}
