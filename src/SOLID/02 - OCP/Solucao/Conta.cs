using System;
using System.Linq;

namespace SOLID.OCP.Solucao
{
    public abstract class Conta
    {
        public string NumeroTransacao { get; set; }

        public abstract string Debitar(decimal valor, string conta);

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
                .Select(x => x[random.Next(x.Length)]).ToArray());

            return NumeroTransacao;
        }
    }
}
