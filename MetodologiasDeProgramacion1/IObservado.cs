using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal interface IObservado
    {
        void AgregarObservador(IObservador ob);
        void EliminarObservador(IObservador ob);
        void Notificar(string accion);
    }
}
