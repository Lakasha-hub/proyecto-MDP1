using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Guerra : JuegoDeCarta
    {
        private List<int> puntaje;
        private GeneradorDeDatosAleatorios gen;
        public Guerra()
        {
            this.puntaje = new List<int> { 0, 0 };
            this.gen = new GeneradorDeDatosAleatorios();
        }

        public override void Mezclar() { Console.WriteLine("Mezclando la baraja española"); }

        public override void Repartir() { Console.WriteLine("Repartiendo 5 cartas a cada jugador"); }

        public override void JugarUnaMano(Persona per1, Persona per2)
        {
            for (int i = 0; i < 5; i++)
            {
                int carta1 = GenerarCarta();
                int carta2 = GenerarCarta();
                Console.WriteLine($"Carta de {per1.GetNombre()}: {carta1}");
                Console.WriteLine($"Carta de {per2.GetNombre()}: {carta2}");
                if (carta1 == carta2)
                    continue;
                else if (carta1 > carta2)
                    this.puntaje[0] += 1;
                else
                    this.puntaje[1] += 1;
            }
        }

        private int GenerarCarta()
        {
            int carta = this.gen.NumeroAleatorio(12);
            return carta == 0 ? 1 : carta;
        }

        public override Persona GetGanador(Persona per1, Persona per2)
        {
            int puntaje1 = this.puntaje[0];
            int puntaje2 = this.puntaje[1];

            if (puntaje1 == puntaje2)
            {
                Console.WriteLine("Es un empate");
                return null;
            }
            else if (puntaje1 > puntaje2)
            {
                Console.WriteLine($"{per1.GetNombre()} ganó la mano");
                return per1;
            }
            else
            {
                Console.WriteLine($"{per2.GetNombre()} ganó la mano");
                return per2;
            }
        }
    }
}
