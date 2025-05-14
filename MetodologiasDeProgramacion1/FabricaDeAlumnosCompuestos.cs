using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeAlumnosCompuestos : FabricaDeAlumnos
    {
        public FabricaDeAlumnosCompuestos() { }
        public override IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new();
            AlumnoCompuesto alumnoComp = new();
            for (int i = 0; i < 5; i++)
            {
                alumnoComp.AgregarHijo(new AlumnoProxy(gen.StringAleatorio(10),
                gen.NumeroAleatorio(99999999),
                gen.NumeroAleatorio(99999),
                gen.NumeroAleatorio(10),
               CrearEstrategiaPorDefecto()));
            }

            return alumnoComp;
        }
    }
}
