using System;
using MetodologíasDeProgramaciónI;

namespace MetodologiasDeProgramacion1
{
    internal class AlumnoAdapter : Student
    {
        Alumno alumno;

        public AlumnoAdapter(Alumno a) { this.alumno = a; }

        public string getName() { return this.alumno.GetNombre(); }

        public int yourAnswerIs(int question) { return this.alumno.ResponderPregunta(question); }

        public void setScore(int score) { this.alumno.SetCalificacion(score); }

        public string showResult() { return this.alumno.MostrarCalificacion(); }

        public bool equals(Student student) { return this.alumno.SosIgual((IComparable)((AlumnoAdapter)student).alumno); }

        public bool lessThan(Student student) { return this.alumno.SosMenor((IComparable)((AlumnoAdapter)student).alumno); }

        public bool greaterThan(Student student) { return this.alumno.SosMayor((IComparable)((AlumnoAdapter)student).alumno); }
    }
}
