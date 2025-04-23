using System;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeNumeros : FabricaDeComparables
    {
        public FabricaDeNumeros() { }

        public override IComparable CrearAleatorio()
        {
            return new Numero(new GeneradorDeDatosAleatorios().NumeroAleatorio(100));
        }

        public override IComparable CrearPorTeclado()
        {
            Console.WriteLine("Ingresa un numero: ");
            return new Numero(new LectorDeDatos().NumeroPorTeclado());
        }
    }
}
