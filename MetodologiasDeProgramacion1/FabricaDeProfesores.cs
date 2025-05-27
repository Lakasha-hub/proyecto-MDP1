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
            CrearCadenaDeResponsabilidad();
            return new Profesor(manejador.StringAleatorio(10),
                manejador.NumeroAleatorio(99999999),
                manejador.NumeroAleatorio(80));
        }

        public override IComparable CrearPorTeclado()
        {
            CrearCadenaDeResponsabilidad();
            Console.WriteLine("Ingresa un nombre: ");
            string nombre = manejador.StringPorTeclado();
            Console.WriteLine("Ingresa un DNI: ");
            int dni = manejador.NumeroPorTeclado();
            Console.WriteLine("Ingresa la antiguedad: ");
            int antiguedad = manejador.NumeroPorTeclado();

            return new Profesor(nombre, dni, antiguedad);
        }

        public override IComparable CrearDesdeArchivo()
        {
            CrearCadenaDeResponsabilidad();
            return new Profesor(manejador.StringDesdeArchivo(10),
                (int)Math.Round(manejador.NumeroDesdeArchivo(100)),
                (int)Math.Round(manejador.NumeroDesdeArchivo(100)));
        }
    }
}
