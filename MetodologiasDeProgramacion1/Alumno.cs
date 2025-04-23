using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class Alumno : Persona, IObservador
    {
        protected int legajo;
        protected int promedio;
        protected IEstrategiaComparacion estrategia;

        public Alumno(string n, int d, int l, int p, IEstrategiaComparacion e) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
            this.estrategia = e;
        }

        public int GetLegajo() { return this.legajo; }

        public int GetPromedio() { return this.promedio; }

        public string GetNombreEstrategia() { return estrategia.GetType().Name; }

        public void SetEstrategia(IEstrategiaComparacion es) { this.estrategia = es; }

        public override string ToString() { return $"Alumno: {GetNombre()} | DNI: {GetDni()} | Promedio: {GetPromedio()} | Legajo: {GetLegajo()} | Estrategia: {GetNombreEstrategia()}"; }

        public void PrestarAtencion() { Console.WriteLine("Prestando atencion"); }

        public void Distraerse()
        {
            GeneradorDeDatosAleatorios gen = new();
            string msj = gen.NumeroAleatorio(2) switch
            {
                0 => "Mirando el celular",
                1 => "Dibujando en el margen de la carpeta",
                2 => "Tirando aviones de papel",
            };

            Console.WriteLine(msj);
        }
        public override bool SosIgual(IComparable cm) { return this.estrategia.Igual(this, cm); }
        public override bool SosMenor(IComparable cm) { return this.estrategia.Menor(this, cm); }
        public override bool SosMayor(IComparable cm) { return this.estrategia.Mayor(this, cm); }

        public void Actualizar(string accion)
        {
            if(accion == "hablar")
            {
                PrestarAtencion();
            }else if (accion == "escribir")
            {
                Distraerse();
            }
        }
    }
}
