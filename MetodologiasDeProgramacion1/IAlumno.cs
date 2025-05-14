using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal interface IAlumno : IObservador, IComparable
    {   
        string GetNombre();
        int GetLegajo();
        int GetPromedio();
        int GetCalificacion();
        int ResponderPregunta(int pregunta);
        void PrestarAtencion();
        void Distraerse();
        string ToString();
        void SetEstrategia(IEstrategiaComparacion es);
        string GetNombreEstrategia();
        void SetCalificacion(int cl);
        string MostrarCalificacion();
    }
}
