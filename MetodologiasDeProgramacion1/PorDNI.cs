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
        public bool Igual(IComparable cm, IComparable cm2) { return ((Persona)cm).GetDni() == ((Persona)cm2).GetDni(); }
        public bool Menor(IComparable cm, IComparable cm2) { return ((Persona)cm).GetDni() < ((Persona)cm2).GetDni(); }
        public bool Mayor(IComparable cm, IComparable cm2) { return ((Persona)cm).GetDni() > ((Persona)cm2).GetDni(); }
    }
}
