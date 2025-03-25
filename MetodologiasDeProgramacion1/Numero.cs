namespace MetodologiasDeProgramacion1
{
    internal class Numero : IComparable
    {
        protected int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int GetValor() { return this.valor; }
        public bool SosIgual(IComparable cm) { return GetValor() == ((Numero)cm).GetValor(); }
        public bool SosMenor(IComparable cm) { return GetValor() < ((Numero)cm).GetValor(); }
        public bool SosMayor(IComparable cm) { return GetValor() > ((Numero)cm).GetValor(); }
        public override string ToString() { return $"Numero: {GetValor()}"; }
    }
}
