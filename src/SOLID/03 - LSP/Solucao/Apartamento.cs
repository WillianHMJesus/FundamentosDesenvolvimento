namespace SOLID.LSP.Solucao
{
    public class Apartamento : Imovel
    {
        public Apartamento(int portas, int janelas, decimal iptu, decimal condominio)
            : base(portas, janelas, iptu)
        {
            Condominio = condominio;
        }

        public decimal Condominio { get; private set; }
    }
}
