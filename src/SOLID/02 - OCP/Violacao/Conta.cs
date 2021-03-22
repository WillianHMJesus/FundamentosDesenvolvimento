namespace SOLID.OCP.Violacao
{
    public class Conta
    {
        public void Debitar(decimal valor, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Corrente)
            {
                //Debitar do saldo
            }

            if(tipoConta == TipoConta.Poupanca)
            {
                //Validar aniversário da conta
                //Debitar do saldo
            }
        }
    }
}
