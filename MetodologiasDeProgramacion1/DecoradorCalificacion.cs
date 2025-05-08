using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal abstract class DecoradorCalificacion : ICalificacion
    {
        protected IAlumno alumno;

        public DecoradorCalificacion(IAlumno c)
        {
            this.alumno = c;
        }

        public virtual string GetNombre() { return this.alumno.GetNombre(); }
        public virtual int GetLegajo() { return this.alumno.GetLegajo(); }
        public virtual int GetPromedio() { return this.alumno.GetPromedio(); }
        public virtual int GetCalificacion() { return this.alumno.GetCalificacion(); }
        public int ResponderPregunta(int pregunta) { return this.alumno.ResponderPregunta(pregunta); }
        public void PrestarAtencion() { this.alumno.PrestarAtencion(); }
        public void Distraerse() { this.alumno.Distraerse(); }
        public override string ToString() { return this.alumno.ToString(); }
        public void SetEstrategia(IEstrategiaComparacion es) { this.alumno.SetEstrategia(es); }
        public string GetNombreEstrategia() { return this.alumno.GetNombreEstrategia(); }
        public void SetCalificacion(int cl) { this.alumno.SetCalificacion(cl); }
        public void Actualizar(string accion) { this.alumno.Actualizar(accion); }
        public bool SosIgual(IComparable cm) { return this.alumno.SosIgual(cm); }
        public bool SosMenor(IComparable cm) { return this.alumno.SosMenor(cm); }
        public bool SosMayor(IComparable cm) { return this.alumno.SosMayor(cm); }
        public Alumno GetAlumno() { return this.alumno.GetAlumno(); }
        public abstract string MostrarCalificacion();
    }
}
