using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class LectorDeDatos
    {
        public int NumeroPorTeclado() { return int.Parse(Console.ReadLine()); }

        public string StringPorTeclado() { return Console.ReadLine(); }
    }
}
