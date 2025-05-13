using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal interface IOrdenable
    {
        void SetOrdenInicio(IOrdenEnAula1 orden);
        void SetOrdenLlegaAlumno(IOrdenEnAula2 orden);
        void SetOrdenAulaLlena(IOrdenEnAula1 orden);
    }
}
