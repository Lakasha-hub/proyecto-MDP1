using System;

namespace MetodologiasDeProgramacion1
{
    internal class GeneradorDeDatosAleatorios
    {
        private static Random random = new Random();
        private const string CARACTERES = "abcdefghijklmnopqrstuvwxyz";
        public int NumeroAleatorio(int max) { return random.Next(0, max + 1); }
        public string StringAleatorio(int cant)
        {
            char[] stringAleatorio = new char[cant];
            for(int i = 0; i < cant; i++)
            {
                stringAleatorio[i] = CARACTERES[NumeroAleatorio(CARACTERES.Length - 1)];
            }

            return new string(stringAleatorio);
        }
    }
}
