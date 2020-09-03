using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto01.Library.Mail
{
    public class Constants
    {
        // POP3, IMAP -- Ler email
        // SMTP --- Enviar

        //Autenticação Gmail
        public readonly static string Usuario = "mvsouza.af@gmail.com";
        public readonly static string Senha = "987994180";

        //Servidor SMTP
        public readonly static string ServidorSMTP = "smtp.gmail.com";
        public readonly static int PortaSMTP = 465;
    }
}
