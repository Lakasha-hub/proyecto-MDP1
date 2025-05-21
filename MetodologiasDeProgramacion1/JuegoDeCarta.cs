using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal abstract class JuegoDeCarta
    {
        // Anotador de manos ganadas por cada jugador
        protected List<int> anotador;
        public Persona Jugar(Persona per1, Persona per2)
        {
            this.anotador = new List<int> { 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Mezclar();
                Repartir();
                JugarUnaMano(per1, per2);

                Persona ganador = GetGanador(per1, per2);
                if (per1 == ganador)
                    this.anotador[0] += 1;
                else if (per2 == ganador)
                    this.anotador[1] += 1;
            }

            if (this.anotador[0] == this.anotador[1])
                return null;
            else if (this.anotador[0] > this.anotador[1])
                return per1;
            else
                return per2;
        }

        public abstract void Mezclar();
        public abstract void Repartir();
        public abstract void JugarUnaMano(Persona per1, Persona per2);
        public abstract Persona GetGanador(Persona per1, Persona per2);
    }
}
