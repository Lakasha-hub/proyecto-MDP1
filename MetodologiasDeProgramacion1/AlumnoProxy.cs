using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class AlumnoProxy : IAlumno
    {
        //Alumno puede ser null
        protected Alumno? alumnoReal;
        protected int legajo;
        protected int promedio;
        protected IEstrategiaComparacion estrategia;
        protected int calificacion;
        protected string nombre;
        protected int dni;

        public AlumnoProxy(string n, int d, int l, int p, IEstrategiaComparacion e)
        {
            this.nombre = n;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
            this.estrategia = e;
            this.calificacion = 0;
        }

        public string GetNombre() { return this.nombre; }
        public int GetDni() { return this.dni; }
        public int GetLegajo() { return this.legajo; }
        public int GetPromedio() { return this.promedio; }
        public int GetCalificacion() { return this.calificacion; }
        public void SetCalificacion(int cl)
        {
            if(this.alumnoReal != null)
                this.alumnoReal.SetCalificacion(cl);
            this.calificacion = cl;
        }
        public string GetNombreEstrategia() { return estrategia.GetType().Name; }
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
        public void Actualizar(string accion)
        {
            if (accion == "hablar")
            {
                PrestarAtencion();
            }
            else if (accion == "escribir")
            {
                Distraerse();
            }
        }
        public string MostrarCalificacion() { return $"{GetNombre()}\t{GetCalificacion()}"; }
        public Alumno GetAlumno()
        {
            if (this.alumnoReal == null)
                this.alumnoReal = CrearAlumnoReal();
            return this.alumnoReal;
        }
        public void SetEstrategia(IEstrategiaComparacion es)
        {
            if (this.alumnoReal != null)
                this.alumnoReal.SetEstrategia(es);
            this.estrategia = es;
        }
        public bool SosIgual(IComparable cm) { return this.estrategia.Igual(this, cm); }
        public bool SosMenor(IComparable cm) { return this.estrategia.Menor(this, cm); }
        public bool SosMayor(IComparable cm) { return this.estrategia.Mayor(this, cm); }
        public virtual int ResponderPregunta(int pregunta)
        {
            if (this.alumnoReal == null)
                this.alumnoReal = CrearAlumnoReal();
            return this.alumnoReal.ResponderPregunta(pregunta);
        }
        protected virtual Alumno CrearAlumnoReal() 
        {
            Console.WriteLine("Creando Alumno real");
            return new Alumno(this.nombre, this.dni, this.legajo, this.promedio, this.estrategia); 
        }
    }
}
