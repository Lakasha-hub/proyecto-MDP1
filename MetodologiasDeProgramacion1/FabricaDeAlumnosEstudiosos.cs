using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeAlumnosEstudiosos : FabricaDeAlumnos
    {
        public FabricaDeAlumnosEstudiosos() { }

        public override IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new();
            return new AlumnoMuyEstudioso(gen.StringAleatorio(10),
                gen.NumeroAleatorio(99999999),
                gen.NumeroAleatorio(99999),
                gen.NumeroAleatorio(10),
               CrearEstrategiaPorDefecto());
        }

        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new();
            Console.WriteLine("Ingresa un nombre: ");
            string nombre = lector.StringPorTeclado();
            Console.WriteLine("Ingresa un DNI: ");
            int dni = lector.NumeroPorTeclado();
            Console.WriteLine("Ingresa un legajo: ");
            int legajo = lector.NumeroPorTeclado();
            Console.WriteLine("Ingresa un promedio: ");
            int promedio = lector.NumeroPorTeclado();

            Console.WriteLine("Ingresa un numero por el tipo de estrategia para el alumno: ");
            Console.WriteLine("1) Por DNI.");
            Console.WriteLine("2) Por Nombre.");
            Console.WriteLine("3) Por Legajo.");
            Console.WriteLine("4) Por Promedio.");
            int estrategiaOpcion = lector.NumeroPorTeclado();

            IEstrategiaComparacion estrategia = estrategiaOpcion switch
            {
                1 => new PorDNI(),
                2 => new PorNombre(),
                3 => new PorLegajo(),
                4 => new PorPromedio(),
                _ => CrearEstrategiaPorDefecto(),
            };
            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio, estrategia);
        }
    }
}
