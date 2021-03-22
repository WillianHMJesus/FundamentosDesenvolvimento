namespace SOLID.OCP.Solucao
{
    public class ContaCorrente : Conta
    {
        public override string Debitar(decimal valor, string conta)
        {
            //Debitar do saldo

            return FormatarTransacao();
        }
    }
}
