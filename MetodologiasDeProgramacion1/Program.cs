namespace MetodologiasDeProgramacion1
{
    using System;
    using MetodologíasDeProgramaciónI;

    class Program {
        static void Main(string[] args)
        {
            // Blackjack
            JuegoDeCarta blackjack = new Blackjack();
            IComparable per1 = FabricaDeComparables.CrearAleatorio("profesor");
            IComparable per2 = FabricaDeComparables.CrearAleatorio("profesor");

            Persona ganador = blackjack.Jugar((Persona)per1, (Persona)per2);
            Console.WriteLine($"El ganador de la partida es {ganador.GetNombre()}");

            // Guerra
            //JuegoDeCarta guerra = new Guerra();
            //IComparable per1 = FabricaDeComparables.CrearAleatorio("profesor");
            //IComparable per2 = FabricaDeComparables.CrearAleatorio("profesor");

            //Persona ganador = guerra.Jugar((Persona)per1, (Persona)per2);
            //Console.WriteLine($"El ganador de la partida es {ganador.GetNombre()}");

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