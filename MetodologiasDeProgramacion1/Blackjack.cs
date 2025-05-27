using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Blackjack : JuegoDeCarta
    {
        private List<int> puntaje;
        private ProveedorDeDatos manejador;

        public Blackjack()
        {
            this.puntaje = [];
            this.manejador = LectorDeDatos.GetInstancia(GeneradorDeDatosAleatorios.GetInstancia(null));
        }

        public override void Mezclar() { Console.WriteLine("Mezclando baraja inglesa"); }

        public override void Repartir() { Console.WriteLine("Repartiendo 2 cartas a cada jugador"); }

        public override void JugarUnaMano(Persona per1, Persona per2)
        {
            int puntaje1 = JugarTurno(per1);
            int puntaje2 = JugarTurno(per2);

            this.puntaje.Clear();
            this.puntaje.Add(puntaje1);
            this.puntaje.Add(puntaje2);

            Console.WriteLine($"Se termino la mano...");
        }

        public int JugarTurno(Persona jugador)
        {
            int cartaVisible = GenerarCartaVisible();
            int total = cartaVisible;

            Console.WriteLine($"El jugador {jugador.GetNombre()} comienza con {cartaVisible}");

            Console.WriteLine($"{jugador.GetNombre()}, ¿Quieres otra carta? 1) Sí  2) No");
            int opcion = this.manejador.NumeroPorTeclado();
            while(opcion != 2)
            {
                int nuevaCarta = GenerarCartaVisible();
                total += nuevaCarta;
                Console.WriteLine($"Nueva carta: {nuevaCarta} -> Total actual: {total}");

                Console.WriteLine($"{jugador.GetNombre()}, ¿Quieres otra carta? 1) Sí  2) No");
                opcion = this.manejador.NumeroPorTeclado();
            }

            Console.WriteLine($"{jugador.GetNombre()} se planta");
            int oculta = GenerarCartaOculta();
            oculta = MejorarAsSiEsPosible(oculta, total);
            return total + oculta;
        }
        private int GenerarCartaVisible()
        {
            int primerCarta = this.manejador.NumeroAleatorio(10);
            if (primerCarta == 0)
                primerCarta++;

            if (primerCarta == 1)
            {
                Console.WriteLine("Te salio un AS, elige su valor 1) Uno, 2) Diez");
                int opcion = this.manejador.NumeroPorTeclado();
                if (opcion == 2)
                    return 10;
                return 1;
            }

            return primerCarta;
        }

        private int GenerarCartaOculta()
        {
            int cartaOculta = this.manejador.NumeroAleatorio(10);
            return cartaOculta == 0 ? 1 : cartaOculta;
        }

        private int MejorarAsSiEsPosible(int carta, int total)
        {
            if (carta == 1 && total + 10 <= 21)
                return 10;
            return carta;
        }

        public override Persona GetGanador(Persona per1, Persona per2)
        {
            int puntaje1 = this.puntaje[0];
            int puntaje2 = this.puntaje[1];

            Console.WriteLine($"{per1.GetNombre()} obtuvo {puntaje1}");
            Console.WriteLine($"{per2.GetNombre()} obtuvo {puntaje2}");

            // Casos de empate
            if ((puntaje1 > 21 && puntaje2 > 21) || puntaje1 == puntaje2)
            {
                Console.WriteLine("Empate, ambos jugadores recuperan sus apuestas");
                return null;
            }

            // Casos donde uno de los dos sobrepasa los 21
            if (puntaje1 > 21 && puntaje2 <= 21)
            {
                Console.WriteLine($"El ganador es {per2.GetNombre()}");
                return per2;
            }

            if (puntaje2 > 21 && puntaje1 <= 21)
            {
                Console.WriteLine($"El ganador es {per1.GetNombre()}");
                return per1;
            }

            //Casos donde ambos son menores que 21
            if (puntaje1 > puntaje2)
            {
                Console.WriteLine($"El ganador es {per1.GetNombre()}");
                return per1;
            }

            if (puntaje2 > puntaje1)
            {
                Console.WriteLine($"El ganador es {per2.GetNombre()}");
                return per2;
            }

            Console.WriteLine("Hubo un error o empate inesperado");
            return null;
        }
    }
}
