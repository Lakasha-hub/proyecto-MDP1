namespace MetodologiasDeProgramacion1
{
    using System;
    using MetodologíasDeProgramaciónI;

    class Program {
        static void Main(string[] args)
        {
            Teacher teacher = new();
            for (int i = 0; i < 5; i++)
            {
                IComparable alumnoAleatorio = FabricaDeComparables.CrearAleatorio("alumno");
                teacher.goToClass(new AlumnoAdapter((IAlumno)alumnoAleatorio));
            }

            for(int i = 0; i < 2; i++)
            {
                IComparable alumnoEstudioso = FabricaDeComparables.CrearPorTeclado("alumnoEstudioso");
                teacher.goToClass(new AlumnoAdapter((IAlumno)alumnoEstudioso));
            }

            for (int i = 0; i < 5; i++)
            {
                IComparable alumnoCompuesto = FabricaDeComparables.CrearDesdeArchivo("alumnoCompuesto");
                teacher.goToClass(new AlumnoAdapter((IAlumno)alumnoCompuesto));
            }

            teacher.teachingAClass();

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
        static void Llenar(IColeccionable cl, string opcion)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable cm = FabricaDeComparables.CrearAleatorio(opcion);
                cl.Agregar(cm);
            }
        }
        static void Informar(IColeccionable cl, string opcion)
        {
            Console.WriteLine($"Cantidad de elementos: {cl.Cuantos()}");
            Console.WriteLine($"Minimo: {cl.Minimo().ToString()}");
            Console.WriteLine($"Maximo: {cl.Maximo().ToString()}");

            IComparable cm = FabricaDeComparables.CrearPorTeclado(opcion);
            Console.WriteLine(cl.Contiene(cm)
                    ? "El elemento leído está en la colección"
                    : "El elemento leído no está en la colección");
        }
        static void ImprimirElementos(Iterable cl)
        {
            IteradorListas ite = cl.CrearIterador();
            while (!ite.Fin())
            {
                Console.WriteLine(ite.Actual().ToString());
                ite.Siguiente();
            }
        }
        static void CambiarEstrategia(Iterable cl, IEstrategiaComparacion es)
        {
            IteradorListas ite = cl.CrearIterador();
            while (!ite.Fin())
            {
                ((Alumno)ite.Actual()).SetEstrategia(es);
                ite.Siguiente();
            }
        }

        static void DictadoDeClase(Profesor prof)
        {
            for(int i = 0; i < 5; i++)
            {
                prof.HablarALaClase();
                prof.EscribirEnElPizarron();
            }
        }
    }
}