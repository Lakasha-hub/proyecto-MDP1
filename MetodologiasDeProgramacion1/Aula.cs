using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodologíasDeProgramaciónI;

namespace MetodologiasDeProgramacion1
{
    internal class Aula
    {
        protected Teacher? teacher;

        public Aula() { }

        public void Comenzar()
        {
            Console.WriteLine("Comienzo de Clases");
            teacher = new Teacher();
        }

        public void NuevoAlumno(IComparable a) { teacher.goToClass(new AlumnoAdapter((IAlumno)a)); }

        public void ClaseLista() { teacher.teachingAClass(); }
    }
}
