using System;

namespace MetodologiasDeProgramacion1
{
    internal abstract class FabricaDeComparables
    {
        protected ProveedorDeDatos? manejador;
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
                "alumnoCompuesto" => new FabricaDeAlumnosCompuestos(),
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
                "alumnoEstudioso" => new FabricaDeAlumnosEstudiosos(),
                "students" => new StudentsFactory(),
                "profesor" => new FabricaDeProfesores(),
                _ => CrearFabricaPorDefecto(),
            };
            return fabrica.CrearPorTeclado();
        }

        public static IComparable CrearDesdeArchivo(string opcion)
        {
            FabricaDeComparables fabrica = opcion switch
            {
                "numero" => new FabricaDeNumeros(),
                "alumno" => new FabricaDeAlumnos(),
                "alumnoEstudioso" => new FabricaDeAlumnosEstudiosos(),
                "profesor" => new FabricaDeProfesores(),
                "students" => new StudentsFactory(),
                "alumnoCompuesto" => new FabricaDeAlumnosCompuestos(),
                _ => CrearFabricaPorDefecto(),
            };
            return fabrica.CrearDesdeArchivo();
        }
        protected void CrearCadenaDeResponsabilidad()
        {
            ProveedorDeDatos m = GeneradorDeDatosAleatorios.GetInstancia(null);
            m = LectorDeDatos.GetInstancia(m);
            m = new LectorDeArchivos(m);
            this.manejador = m;
        }

        public abstract IComparable CrearAleatorio();
        public abstract IComparable CrearPorTeclado();
        public abstract IComparable CrearDesdeArchivo();
    }
}
