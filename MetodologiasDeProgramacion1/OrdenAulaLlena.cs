using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class OrdenAulaLlena : IOrdenEnAula1
    {
        protected Aula aula;

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        public void Ejecutar() { this.aula.ClaseLista(); }
    }
}
