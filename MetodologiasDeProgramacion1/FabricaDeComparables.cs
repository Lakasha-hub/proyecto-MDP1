using System;

namespace MetodologiasDeProgramacion1
{
    internal abstract class FabricaDeComparables
    {
        private static FabricaDeNumeros CrearFabricaPorDefecto() { return new FabricaDeNumeros(); }
        public static IComparable CrearAleatorio(string opcion)
        {
            FabricaDeComparables fabrica = opcion switch
            {
                "numero" => new FabricaDeNumeros(),
                "alumno" => new FabricaDeAlumnos(),
                "alumnoEstudioso" => new FabricaDeAlumnosEstudiosos(),
                "profesor" => new FabricaDeProfesores(),
                "students" => new StudentsFactory(),
                _ => CrearFabricaPorDefecto(),
            };
            return fabrica.CrearAleatorio();
        }
        public static IComparable CrearPorTeclado(string opcion)
        {
            FabricaDeComparables fabrica = opcion switch
            {
                "numero" => new FabricaDeNumeros(),
                "alumno" => new FabricaDeAlumnos(),
                "profesor" => new FabricaDeProfesores(),
                _ => CrearFabricaPorDefecto(),
            };
            return fabrica.CrearPorTeclado();
        }

        public abstract IComparable CrearAleatorio();
        public abstract IComparable CrearPorTeclado();
    }
}
