namespace OOP
{
    public abstract class Conta
    {
        public decimal Saldo { get; protected set; }

        public abstract void Debitar(decimal valor);

        public void Depositar(decimal valor) => Saldo += valor;
    }
}
