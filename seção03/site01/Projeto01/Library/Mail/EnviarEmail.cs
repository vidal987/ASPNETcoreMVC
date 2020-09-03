using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Projeto01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> Email: {1}<br /> Assunto: {2}<br />Mensagem: {3} ", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
            // Comfigurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            //Mensagem de Email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("mvsouza.af@gmail.com");
            mensagem.To.Add("mvsouza.af@gmail.com");
            mensagem.Subject = "Formulário de contato";

            mensagem.IsBodyHtml = true;
            mensagem.Body = "<h1>Formulário de contato</h1>" + conteudo;

            smtp.Send(mensagem);

        }
    }
}
