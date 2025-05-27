using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal class LectorDeDatos : ProveedorDeDatos
    {
        private static LectorDeDatos? lector = null;
        public LectorDeDatos(ProveedorDeDatos? p) : base(p){ }

        public override int NumeroPorTeclado() { return int.Parse(Console.ReadLine()); }

        public override string StringPorTeclado() { return Console.ReadLine(); }

        public static LectorDeDatos GetInstancia(ProveedorDeDatos p)
        {
            if (lector == null)
                return new LectorDeDatos(p);
            return lector;
        } 
    }
}
