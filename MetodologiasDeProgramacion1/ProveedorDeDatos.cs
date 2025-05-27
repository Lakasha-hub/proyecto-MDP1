using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasDeProgramacion1
{
    internal abstract class ProveedorDeDatos
    {
        protected ProveedorDeDatos? proveedor = null;
        public ProveedorDeDatos(ProveedorDeDatos p)
        {
            this.proveedor = p;
        }

        public virtual int NumeroPorTeclado()
        {
            if (proveedor != null)
                return proveedor.NumeroPorTeclado();
            return 0;
        }

        public virtual string StringPorTeclado()
        {
            if (proveedor != null)
                return proveedor.StringPorTeclado();
            return "Hubo un error en StringPorTeclado";
        }

        public virtual string StringAleatorio(int cant)
        {
            if (proveedor != null)
                return proveedor.StringAleatorio(cant);
            return "Hubo un error en StringAleatorio";
        }

        public virtual int NumeroAleatorio(int max)
        {
            if (proveedor != null)
                return proveedor.NumeroAleatorio(max);
            return 0;
        }

        public virtual double NumeroDesdeArchivo(double max)
        {
            if (proveedor != null)
                return proveedor.NumeroDesdeArchivo(max);
            return 0;
        }

        public virtual string StringDesdeArchivo(int cant)
        {
            if (proveedor != null)
                return proveedor.StringDesdeArchivo(cant);
            return "Hubo un error en StringDesdeArchivo";
        }
    }
}
