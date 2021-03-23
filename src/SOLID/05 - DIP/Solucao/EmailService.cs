using System.Net.Mail;

namespace SOLID.DIP.Solucao
{
    public class EmailService : IEmailService
    {
        public void Enviar(string de, string para, string titulo, string mensagem)
        {
            var mailMessage = new MailMessage(de, para);
            var smtpClient = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = titulo;
            mailMessage.Body = mensagem;
            smtpClient.Send(mailMessage);
        }
    }
}
