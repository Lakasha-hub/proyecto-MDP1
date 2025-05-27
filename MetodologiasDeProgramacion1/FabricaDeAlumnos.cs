using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeAlumnos : FabricaDeComparables
    {
        public FabricaDeAlumnos() { }
        public override IComparable CrearAleatorio()
        {
            CrearCadenaDeResponsabilidad();
            return new AlumnoProxy(manejador.StringAleatorio(10),
                manejador.NumeroAleatorio(99999999),
                manejador.NumeroAleatorio(99999),
                manejador.NumeroAleatorio(10),
               CrearEstrategiaPorDefecto());
        }

        protected IEstrategiaComparacion CrearEstrategiaPorDefecto() { return new PorPromedio(); }

        protected IEstrategiaComparacion CrearEstrategiaAleatoria()
        {
            CrearCadenaDeResponsabilidad();
            int opcionAleatoria = manejador.NumeroAleatorio(3);
            IEstrategiaComparacion estrategia = opcionAleatoria switch
            {
                0 => new PorDNI(),
                1 => new PorNombre(),
                2 => new PorLegajo(),
                3 => new PorPromedio(),
            };
            return estrategia;
        }
        public override IComparable CrearPorTeclado()
        {
            CrearCadenaDeResponsabilidad();
            Console.WriteLine("Ingresa un nombre: ");
            string nombre = manejador.StringPorTeclado();
            Console.WriteLine("Ingresa un DNI: ");
            int dni = manejador.NumeroPorTeclado();
            Console.WriteLine("Ingresa un legajo: ");
            int legajo = manejador.NumeroPorTeclado();
            Console.WriteLine("Ingresa un promedio: ");
            int promedio = manejador.NumeroPorTeclado();

            Console.WriteLine("Ingresa un numero por el tipo de estrategia para el alumno: ");
            Console.WriteLine("1) Por DNI.");
            Console.WriteLine("2) Por Nombre.");
            Console.WriteLine("3) Por Legajo.");
            Console.WriteLine("4) Por Promedio.");
            int estrategiaOpcion = manejador.NumeroPorTeclado();

            IEstrategiaComparacion estrategia = estrategiaOpcion switch
            {
                1 => new PorDNI(),
                2 => new PorNombre(),
                3 => new PorLegajo(),
                4 => new PorPromedio(),
                _ => CrearEstrategiaPorDefecto(),
            };
            return new AlumnoProxy(nombre, dni, legajo, promedio, estrategia);
        }

        public override IComparable CrearDesdeArchivo()
        {
            CrearCadenaDeResponsabilidad();
            return new AlumnoProxy(manejador.StringDesdeArchivo(10),
                (int)Math.Round(manejador.NumeroDesdeArchivo(10)),
                (int)Math.Round(manejador.NumeroDesdeArchivo(99999)),
                (int)Math.Round(manejador.NumeroDesdeArchivo(10)),
               CrearEstrategiaPorDefecto());
        }

    }
}
