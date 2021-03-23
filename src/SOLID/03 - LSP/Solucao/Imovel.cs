using System;

namespace SOLID.LSP.Solucao
{
    public abstract class Imovel
    {
        public Imovel(int portas, int janelas, decimal iptu)
        {
            ImovelId = Guid.NewGuid();
            Portas = portas;
            Janelas = janelas;
            IPTU = iptu;
        }

        public Guid ImovelId { get; private set; }
        public int Portas { get; private set; }
        public int Janelas { get; private set; }
        public decimal IPTU { get; private set; }
    }
}
