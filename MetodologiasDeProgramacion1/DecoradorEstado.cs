using System;

namespace MetodologiasDeProgramacion1
{
    internal class DecoradorEstado : DecoradorCalificacion
    {
        public DecoradorEstado(IAlumno c) : base(c) { }

        public override string MostrarCalificacion()
        {
            string estado;
            if (GetCalificacion() >= 7)
                estado = "PROMOCION";
            else if (GetCalificacion() >= 4)
                estado = "APROBADO";
            else
                estado = "DESAPROBADO";

            return $"{((ICalificacion)this.alumno).MostrarCalificacion()}({estado})";
        }
    }
}
