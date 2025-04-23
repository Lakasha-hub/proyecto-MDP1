namespace MetodologiasDeProgramacion1
{
    using System;
    class Program {
        static void Main(string[] args)
        {
            Profesor prof = (Profesor)FabricaDeComparables.CrearAleatorio("profesor");
            for (int i = 0; i < 20; i++)
            {
                IObservador ob = (IObservador)FabricaDeComparables.CrearAleatorio("alumno");
                prof.AgregarObservador(ob);
            }
            DictadoDeClase(prof);

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