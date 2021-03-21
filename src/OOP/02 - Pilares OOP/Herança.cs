using System;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Mario Jorge da Silva",
                DataNascimento = new DateTime(1990, 09, 20),
                DataAdmissao = DateTime.Now,
                Registro = "10102050"
            };
            var idade = funcionario.CalcularIdade();
        }
    }
}
