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
            CrearCadenaDeResponsabilidad();
            AlumnoCompuesto alumnoComp = new();
            for (int i = 0; i < 5; i++)
            {
                alumnoComp.AgregarHijo(new AlumnoProxy(manejador.StringAleatorio(10),
                manejador.NumeroAleatorio(99999999),
                manejador.NumeroAleatorio(99999),
                manejador.NumeroAleatorio(10),
               CrearEstrategiaPorDefecto()));
            }

            return alumnoComp;
        }

        public override IComparable CrearDesdeArchivo()
        {
            CrearCadenaDeResponsabilidad();
            AlumnoCompuesto alumnoComp = new();
            for (int i = 0; i < 5; i++)
            {
                alumnoComp.AgregarHijo(new AlumnoProxy(manejador.StringDesdeArchivo(10),
                (int)Math.Round(manejador.NumeroDesdeArchivo(10)),
                (int)Math.Round(manejador.NumeroDesdeArchivo(99999)),
                (int)Math.Round(manejador.NumeroDesdeArchivo(10)),
               CrearEstrategiaPorDefecto()));
            }

            return alumnoComp;
        }
    }
}
