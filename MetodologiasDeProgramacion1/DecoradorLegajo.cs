using System;

namespace MetodologiasDeProgramacion1
{
    internal class DecoradorLegajo : DecoradorCalificacion
    {
        public DecoradorLegajo(IAlumno c) : base(c) { }

        public override string MostrarCalificacion() { return $"{GetNombre()}({GetLegajo()})\t{GetCalificacion()}"; }
    }
}
