using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.SRP.Violacao
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public string Adicionar()
        {
            if (!Email.Contains("@"))
                throw new Exception("E-mail inválido");

            if (CPF.Length != 11)
                throw new Exception("CPF inválido");

            if (Senha.Length < 6)
                throw new Exception("Senha inválida");

            using (var connection = new SqlConnection("ConnectionString"))
            {
                using (var command = new SqlCommand("Script de Insert", connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("Nome", Nome);
                    command.Parameters.AddWithValue("Email", Email);
                    command.Parameters.AddWithValue("CPF", CPF);
                    command.Parameters.AddWithValue("Senha", Senha);
                    command.Parameters.AddWithValue("DataCadastro", DataCadastro);

                    command.ExecuteNonQuery();
                }
            }

            var mailMessage = new MailMessage("nãoReponder@empresa.com", Email);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = "Bem vindo.";
            mailMessage.Body = "Parabéns! Seu cadastro foi realizado com sucesso.";
            smtpClient.Send(mailMessage);

            return "Usuário cadastrado com sucesso";
        }
    }
}
