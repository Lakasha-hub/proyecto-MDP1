using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class AlumnoMuyEstudiosoProxy : AlumnoProxy
    {
        public AlumnoMuyEstudiosoProxy(string n, int d, int l, int p, IEstrategiaComparacion e) : base(n, d, l, p, e) { }
        protected override Alumno CrearAlumnoReal()
        {
            Console.WriteLine("Creando Alumno Estudioso real");
            return new AlumnoMuyEstudioso(this.nombre, this.dni, this.legajo, this.promedio, this.estrategia);
        }
    }
}
