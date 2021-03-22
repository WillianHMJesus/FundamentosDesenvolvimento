using System;

namespace SOLID.SRP.Solucao
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public CPF CPF { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar() => Email.Validar() && CPF.Validar() && Senha.Length > 5;
    }
}
