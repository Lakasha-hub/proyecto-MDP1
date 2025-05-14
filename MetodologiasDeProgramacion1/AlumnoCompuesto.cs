using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class AlumnoCompuesto : IAlumno
    {
        protected List<IAlumno> alumnos;

        public AlumnoCompuesto()
        {
            this.alumnos = [];
        }

        public void AgregarHijo(IAlumno a) { this.alumnos.Add(a); }

        public string GetNombre()
        {
            string nombres = "";
            foreach(IAlumno al in this.alumnos)
            {
                nombres += al.GetNombre() + " ";
            }
            return nombres;
        }

        public int ResponderPregunta(int pregunta)
        {
            // Formato del diccionario de respuestas (Respuesta[key], cantidadDeVeces[value])
            Dictionary<int,int> conteoRespuestas = new Dictionary<int, int>();
            foreach(IAlumno al in this.alumnos)
            {
                int res = al.ResponderPregunta(pregunta);
                if (conteoRespuestas.ContainsKey(res))
                    conteoRespuestas[res]++;
                else
                    conteoRespuestas.Add(res, 1);
            }

            return conteoRespuestas.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }

        public void SetCalificacion(int calificacionNueva)
        {
            foreach(IAlumno al in this.alumnos)
            {
                al.SetCalificacion(calificacionNueva);
            }
        }

        public string MostrarCalificacion()
        {
            string result = "";
            foreach(IAlumno al in this.alumnos)
            {
                result += al.MostrarCalificacion() + "\n";
            }
            return result;
        }

        public bool SosIgual(IComparable cm)
        {
            for(int i = 0; i < this.alumnos.Count; i++)
            {
                if (this.alumnos[i].SosIgual(cm))
                    return true;
            }
            return false;
        }

        public bool SosMenor(IComparable cm)
        {
            foreach(IAlumno al in this.alumnos)
            {
                if (!al.SosMenor(cm))
                    return false;
            }
            return true;
        }

        public bool SosMayor(IComparable cm)
        {
            foreach (IAlumno al in this.alumnos)
            {
                if (!al.SosMayor(cm))
                    return false;
            }
            return true;
        }

        public int GetPromedio()
        {
            if (this.alumnos.Count == 0)
                return 0;

            int sumaPromedios = 0;
            foreach (IAlumno al in this.alumnos)
            {
                sumaPromedios += al.GetPromedio();
            }
            return sumaPromedios / this.alumnos.Count;
        }

        public override string ToString()
        {
            string result = "";
            foreach (IAlumno al in this.alumnos)
            {
                result += al.ToString() + "\n";
            }
            return result;
        }

        /* Metodos que no son necesarios de implementar para la práctica 6 */
        public int GetLegajo() { return 0; }
        public int GetCalificacion() { return 0; }
        public string GetNombreEstrategia() { return ""; }
        public void Actualizar(string accion) { }
        public void Distraerse() { }
        public void PrestarAtencion() { }
        public void SetEstrategia(IEstrategiaComparacion e) { }
    }
}
