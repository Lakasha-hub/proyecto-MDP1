using System;

namespace MetodologiasDeProgramacion1
{
    internal class GeneradorDeDatosAleatorios : ProveedorDeDatos
    {
        private static Random random = new Random();
        private const string CARACTERES = "abcdefghijklmnopqrstuvwxyz";
        private static GeneradorDeDatosAleatorios? generador = null;

        private GeneradorDeDatosAleatorios(ProveedorDeDatos? p) : base(p) { }
        public override int NumeroAleatorio(int max) { return random.Next(0, max + 1); }
        public override string StringAleatorio(int cant)
        {
            char[] stringAleatorio = new char[cant];
            for(int i = 0; i < cant; i++)
            {
                stringAleatorio[i] = CARACTERES[NumeroAleatorio(CARACTERES.Length - 1)];
            }

            return new string(stringAleatorio);
        }

        public static GeneradorDeDatosAleatorios GetInstancia(ProveedorDeDatos p)
        {
            if (generador == null)
                return new GeneradorDeDatosAleatorios(p);
            return generador;
        }
    }
}
