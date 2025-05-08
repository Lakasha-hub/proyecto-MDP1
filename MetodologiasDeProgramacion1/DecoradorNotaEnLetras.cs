using System;

namespace MetodologiasDeProgramacion1
{
    internal class DecoradorNotaEnLetras : DecoradorCalificacion
    {
        private static readonly string[] NOTAS =
        {
            "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO",
            "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"
        };
        public DecoradorNotaEnLetras(IAlumno c) : base(c) { }

        public override string MostrarCalificacion()
        {
            string nota = GetCalificacion() >= 0 && GetCalificacion() <= 10 ?
                NOTAS[GetCalificacion()] : "Invalido";

            return $"{((ICalificacion)this.alumno).MostrarCalificacion()}({nota})";
        }
    }
}
