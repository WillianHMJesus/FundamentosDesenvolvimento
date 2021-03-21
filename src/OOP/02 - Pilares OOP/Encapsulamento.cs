namespace OOP
{
    public class Transacao
    {
        public Transacao()
        {
            Conta contaCorrente = new ContaCorrente();
            contaCorrente.Depositar(100);
            contaCorrente.Debitar(100);

            Conta contaPoupanca = new ContaPoupanca();
            contaPoupanca.Depositar(150);
            contaPoupanca.Debitar(150);
        }
    }
}
