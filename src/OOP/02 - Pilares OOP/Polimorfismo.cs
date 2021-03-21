namespace OOP
{
    public class ContaCorrente : Conta
    {
        private bool ValidarDebito()
        {
            //Implementar regra de débito de conta corrente
            return true;
        }

        public override void Debitar(decimal valor)
        {
            if (ValidarDebito())
            {
                Saldo -= valor;
            }
        }
    }

    public class ContaPoupanca : Conta
    {
        private bool ValidarDebito()
        {
            //Implementar regra de débito de conta poupança
            return true;
        }

        public override void Debitar(decimal valor)
        {
            if(ValidarDebito())
            {
                Saldo -= valor;
            }
        }
    }
}
