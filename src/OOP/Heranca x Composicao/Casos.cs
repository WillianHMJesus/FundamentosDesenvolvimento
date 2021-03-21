using System;

namespace OOP
{
    public class PessoaHeranca : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaComposicao
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class UsoHerancaComposicao
    {
        public UsoHerancaComposicao()
        {
            var pessoaHeranca = new PessoaHeranca()
            {
                PessoaId = Guid.NewGuid(),
                Nome = "José dos Santos",
                DataNascimento = DateTime.Now.AddYears(-18),
                Cpf = "66876628051"
            };

            var pessoaComposicao = new PessoaComposicao()
            {
                Pessoa = new Pessoa()
                {
                    PessoaId = Guid.NewGuid(),
                    Nome = "José dos Santos",
                    DataNascimento = DateTime.Now.AddYears(-18)
                },
                Cpf = "66876628051"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }
}
