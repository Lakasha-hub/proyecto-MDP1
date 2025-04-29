using System;

namespace MetodologiasDeProgramacion1
{
    internal class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string n, int d, int l, int p, IEstrategiaComparacion e) : base(n, d, l, p, e)
        {
        }

        public override int ResponderPregunta(int pregunta) { return pregunta % 3; }
    }
}
