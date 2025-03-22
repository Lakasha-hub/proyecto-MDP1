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

            // Ejercicio 14
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
            Console.WriteLine(cl.Cuantos());
            Console.WriteLine(((Numero)cl.Minimo()).GetValor());
            Console.WriteLine(((Numero)cl.Maximo()).GetValor());

            Console.WriteLine("Ingrese un número para ver si esta en la colección");
            IComparable num = new Numero(int.Parse(Console.ReadLine()));
            Console.WriteLine(cl.Contiene(num) 
                ? "El elemento leído está en la colección"
                : "El elemento leído no está en la colección");
        }

        static void LlenarAlumnos(IColeccionable cl)
        {
            for(int i = 0; i < 20; i++)
            {
                IComparable nuevoAlumno = new Alumno(GenerarNombreRandom(), GenerarNumRandom(1111111, 99999999),
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