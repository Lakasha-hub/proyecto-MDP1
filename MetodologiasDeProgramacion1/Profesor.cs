using System;
using System.Globalization;

namespace MetodologiasDeProgramacion1
{
    internal class Profesor : Persona, IObservado
    {
        protected int antiguedad;
        protected List<IObservador> observadores;
        private IEstrategiaComparacion estrategia;

        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.antiguedad = a;
            this.observadores = [];
            this.estrategia = new PorAntiguedad();
        }

        public int GetAntiguedad() { return this.antiguedad; }

        public List<IObservador> GetListaDeObservadores() { return this.observadores; }

        public string GetNombreEstrategia() { return this.estrategia.GetType().Name; }

        public override string ToString() { return $"Profesor: {GetNombre()} | DNI: {GetDni()} | Antiguedad: {GetAntiguedad()} | Estrategia: {GetNombreEstrategia()}"; }
        
        public void HablarALaClase() 
        { 
            Console.WriteLine("\nHablando de algun tema");
            Notificar("hablar");
        }

        public void EscribirEnElPizarron() 
        { 
            Console.WriteLine("\nEscribiendo en el pizarron");
            Notificar("escribir");
        }

        public override bool SosIgual(IComparable cm) { return this.estrategia.Igual(this, cm); }

        public override bool SosMenor(IComparable cm) { return this.estrategia.Menor(this, cm); }

        public override bool SosMayor(IComparable cm) { return this.estrategia.Mayor(this, cm); }

        public void AgregarObservador(IObservador ob) { this.observadores.Add(ob); }

        public void EliminarObservador(IObservador ob) { this.observadores.Remove(ob); }

        public void Notificar(string accion)
        {
            foreach (var item in this.observadores)
            {
                item.Actualizar(accion);
            }
        }
    }
}
