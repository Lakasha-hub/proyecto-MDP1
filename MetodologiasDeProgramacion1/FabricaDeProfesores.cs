using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeProfesores : FabricaDeComparables
    {
        public FabricaDeProfesores() { }
        public override IComparable CrearAleatorio()
        {
            GeneradorDeDatosAleatorios gen = new();
            return new Profesor(gen.StringAleatorio(10),
                gen.NumeroAleatorio(99999999),
                gen.NumeroAleatorio(80));
        }

        public override IComparable CrearPorTeclado()
        {
            LectorDeDatos lector = new();
            Console.WriteLine("Ingresa un nombre: ");
            string nombre = lector.StringPorTeclado();
            Console.WriteLine("Ingresa un DNI: ");
            int dni = lector.NumeroPorTeclado();
            Console.WriteLine("Ingresa la antiguedad: ");
            int antiguedad = lector.NumeroPorTeclado();

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}
