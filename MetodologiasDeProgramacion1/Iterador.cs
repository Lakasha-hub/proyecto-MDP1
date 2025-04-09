using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal interface Iterador
    {
        IComparable Actual();
        void Siguiente();
        bool Fin();
    }
}
