using System;

namespace SOLID.LSP.Violacao
{
    public class Casa
    {
        public Casa(int portas, int janelas, decimal iptu)
        {
            CasaId = Guid.NewGuid();
            Portas = portas;
            Janelas = janelas;
            IPTU = iptu;
        }

        public Guid CasaId { get; private set; }
        public int Portas { get; private set; }
        public int Janelas { get; private set; }
        public decimal IPTU { get; private set; }
    }
}
