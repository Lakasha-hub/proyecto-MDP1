using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class PorDNI : IEstrategiaComparacion
    {
        public bool Igual(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetDni() == ((IAlumno)cm2).GetAlumno().GetDni(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetDni() < ((IAlumno)cm2).GetAlumno().GetDni(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((IAlumno)cm).GetAlumno().GetDni() > ((IAlumno)cm2).GetAlumno().GetDni(); }
    }
}
