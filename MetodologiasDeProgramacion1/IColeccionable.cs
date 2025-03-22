using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    public interface IColeccionable
    {
        int Cuantos();
        IComparable Minimo();
        IComparable Maximo();
        void Agregar(IComparable cm);
        bool Contiene(IComparable cm);

    }
}
