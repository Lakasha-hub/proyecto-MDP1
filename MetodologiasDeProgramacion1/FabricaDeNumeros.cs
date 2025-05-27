using System;

namespace MetodologiasDeProgramacion1
{
    internal class FabricaDeNumeros : FabricaDeComparables
    {
        public FabricaDeNumeros() { }

        public override IComparable CrearAleatorio()
        {
            CrearCadenaDeResponsabilidad();
            return new Numero(manejador.NumeroAleatorio(100));
        }

        public override IComparable CrearPorTeclado()
        {
            Console.WriteLine("Ingresa un numero: ");
            CrearCadenaDeResponsabilidad();
            return new Numero(manejador.NumeroPorTeclado());
        }

        public override IComparable CrearDesdeArchivo()
        {
            CrearCadenaDeResponsabilidad();
            return new Numero((int)Math.Round(manejador.NumeroDesdeArchivo(100)));
        }
    }
}
