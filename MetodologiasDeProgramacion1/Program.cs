namespace MetodologiasDeProgramacion1
{
    using System;
    class Program {

        private static Random random = new Random();
        static void Main(string[] args)
        {
            // Ejercicio 7
            //Pila pila = new();
            //Cola cola = new();
            //Llenar(pila);
            //Llenar(cola);
            //Informar(pila);
            //Informar(cola);

            // Ejercicio 9
            //Pila pila = new();
            //Cola cola = new();
            //ColeccionMultiple multiple = new(pila, cola);
            //Llenar(pila);
            //Llenar(cola);
            //Informar(pila);
            //Informar(cola);
            //Informar(multiple);

            // Ejercicio 14 y 15
            Pila pila = new();
            Cola cola = new();
            ColeccionMultiple multiple = new(pila, cola);
            LlenarAlumnos(pila);
            LlenarAlumnos(cola);
            Informar(multiple);
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

            Console.WriteLine("Ingrese un elemento para ver si esta en la colección");
            int opt = int.Parse(Console.ReadLine());

            // Solucion Temporal para Ej 14 y 15
            IComparable newCM;
            if(cl.Minimo() is Alumno)
            {
                //Evaluacion por DNI: (Nota: Para probar se deben comentar o eliminar los metodos override de Alumno)
                // newCM = new Alumno("", opt, 0, 0);

                //Evaluacion por Promedio
                newCM = new Alumno("", 0, 0, opt);
            }
            else if (cl.Minimo() is Numero)
            {
                newCM = new Numero(opt);
            }
            else
            {
                Console.WriteLine("Tipo de dato no identificado");
                return;
            }

                Console.WriteLine(cl.Contiene(newCM)
                    ? "El elemento leído está en la colección"
                    : "El elemento leído no está en la colección");
        }

        static void LlenarAlumnos(IColeccionable cl)
        {
            for(int i = 0; i < 20; i++)
            {
                IComparable nuevoAlumno = new Alumno(GenerarNombreRandom(), GenerarNumRandom(11111111, 99999999),
                    GenerarNumRandom(10000, 99999), GenerarNumRandom(1, 10));
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
    }
}