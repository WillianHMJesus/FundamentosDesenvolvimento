﻿using System.Net.Mail;

namespace SOLID.SRP.Solucao
{
    public class EmailServico
    {
        public static void Enviar(string de, string para, string titulo, string mensagem)
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
