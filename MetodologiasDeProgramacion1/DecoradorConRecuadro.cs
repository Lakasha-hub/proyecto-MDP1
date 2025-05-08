using System;

namespace MetodologiasDeProgramacion1
{
    internal class DecoradorConRecuadro : DecoradorCalificacion
    {
        public DecoradorConRecuadro(IAlumno c) : base(c) { }

        public override string MostrarCalificacion()
        {
            return $"**********************************************\n* {((ICalificacion)this.alumno).MostrarCalificacion()} *\n**********************************************";
        }
    }
}
