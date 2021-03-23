namespace SOLID.LSP.Violacao
{
    public class Apartamento : Casa
    {
        public Apartamento(int portas, int janelas, decimal iptu, decimal condominio)
            : base(portas, janelas, iptu)
        {
            Condominio = condominio;
        }

        public decimal Condominio { get; private set; }
    }
}
