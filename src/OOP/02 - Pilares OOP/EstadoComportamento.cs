using System;

namespace OOP
{
    public class Pessoa
    {
        //Definição de Estado
        public Guid PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        //Definição de Comportamento
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
