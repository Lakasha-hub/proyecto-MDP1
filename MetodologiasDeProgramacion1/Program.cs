namespace MetodologiasDeProgramacion1
{
    using System;
    class Program {

        private static Random random = new Random();

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            Llenar(pila);
            Llenar(cola);
            Informar(pila);
            Informar(cola);
            Informar(multiple);
        }

        static void Llenar(IColeccionable cl)
        {
            for (int i = 0; i < 20; i++)
            {
                IComparable newCl = new Numero(GenerarNumRandom(1, 100));
                cl.Agregar(newCl);
            }
        }

        static int GenerarNumRandom(int min, int max) { return random.Next(min, max + 1); }

        static void Informar(IColeccionable cl)
        {
            Console.WriteLine(cl.Cuantos());
            Console.WriteLine(((Numero)cl.Minimo()).GetValor());
            Console.WriteLine(((Numero)cl.Maximo()).GetValor());

            Console.WriteLine("Ingrese un número para ver si esta en la colección");
            IComparable cm = new Numero(int.Parse(Console.ReadLine()));
            Console.WriteLine(cl.Contiene(cm) 
                ? "El elemento leído esta en la colección"
                : "El elemento leído no está en la colección");
        }
    }
}