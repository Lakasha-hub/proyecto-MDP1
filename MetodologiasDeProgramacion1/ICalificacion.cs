using System;

namespace MetodologiasDeProgramacion1
{
    internal interface ICalificacion : IAlumno
    {
        string MostrarCalificacion();
        string GetNombre();
        int GetCalificacion();
        int GetLegajo();
    }
}
