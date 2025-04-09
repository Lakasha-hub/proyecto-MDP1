namespace MetodologiasDeProgramacion1
{
    using System;
    class Program {

        private static Random random = new Random();
        static void Main(string[] args)
        {
            // Ejercicio 2
            //Pila pila = new();
            //Cola cola = new();
            //ColeccionMultiple multiple = new(pila, cola);
            //LlenarAlumnos(pila);
            //LlenarAlumnos(cola);
            //Informar(multiple);

            // Ejercicio 7
            //Pila pila = new();
            //Cola cola = new();
            //Conjunto conjunto = new();
            //LlenarAlumnos(pila);
            //LlenarAlumnos(cola);
            //LlenarAlumnos(conjunto);
            //Console.WriteLine("\n***************************** Pila *****************************");
            //ImprimirElementos(pila);
            //Console.WriteLine("\n***************************** Cola *****************************");
            //ImprimirElementos(cola);
            //Console.WriteLine("\n***************************** Conjunto *****************************");
            //ImprimirElementos(conjunto);

            // Ejercicio 9
            Pila pila = new();
            LlenarAlumnos(pila);
            Console.WriteLine("\n***************************** Comparacion por DNI: *****************************");
            Informar(pila);
            CambiarEstrategia(pila, new PorNombre());
            Console.WriteLine("\n***************************** Comparacion por Nombre: *****************************");
            Informar(pila);           
            CambiarEstrategia(pila, new PorLegajo());
            Console.WriteLine("\n***************************** Comparacion por Legajo: *****************************");
            Informar(pila);
            CambiarEstrategia(pila, new PorPromedio());
            Console.WriteLine("\n***************************** Comparacion por Promedio: *****************************");
            Informar(pila);

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
        static void Llenar(IColeccionable cl)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable nuevoNum = new Numero(GenerarNumRandom(1, 100));
                cl.Agregar(nuevoNum);
            }
        }
        static int GenerarNumRandom(int min, int max) { return random.Next(min, max + 1); }
        static void Informar(IColeccionable cl)
        {
            Console.WriteLine($"Cantidad de elementos: {cl.Cuantos()}");
            Console.WriteLine($"Minimo: {cl.Minimo().ToString()}");
            Console.WriteLine($"Maximo: {cl.Maximo().ToString()}");

            //Console.WriteLine("Ingrese un elemento para ver si esta en la colección");
            //int opt = int.Parse(Console.ReadLine());

            //IComparable newCM;
            //if(cl.Minimo() is Alumno)
            //{
            //    newCM = new Alumno("", opt, 0, 0);
            //}
            //else if (cl.Minimo() is Numero)
            //{
            //    newCM = new Numero(opt);
            //}
            //else
            //{
            //    Console.WriteLine("Tipo de dato no identificado");
            //    return;
            //}

            //    Console.WriteLine(cl.Contiene(newCM)
            //        ? "El elemento leído está en la colección"
            //        : "El elemento leído no está en la colección");
        }

        static void LlenarAlumnos(IColeccionable cl)
        {
            for(int i = 0; i < 20; i++)
            {
                IComparable nuevoAlumno = new Alumno(GenerarNombreRandom(), GenerarNumRandom(11111111, 99999999),
                    GenerarNumRandom(10000, 99999), GenerarNumRandom(1, 10), new PorDNI());
                cl.Agregar(nuevoAlumno);
            }
        }
        static string GenerarNombreRandom()
        {
            List<string> nombres = new List<string>
            {
                "Lautaro", "Marcos", "José", "Lucas", "Leandro",
                "Carlos", "Gustavo", "Cristian", "Iván", "Franco",
                "Amparo", "Sofia", "Kiara", "Milagros", "Delfina",
                "Julieta", "Claudia", "Maria", "Cecilia", "Anahí"
            };

            return nombres[random.Next(0, 20)];
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
    }
}