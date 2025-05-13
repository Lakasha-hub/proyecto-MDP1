using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class OrdenLlegaAlumno : IOrdenEnAula2
    {
        protected Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void Ejecutar(IComparable cm) { this.aula.NuevoAlumno(cm); }
    }
}
