using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto01.Library.Mail;
using Projeto01.Models;

namespace Projeto01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //Entra
                // string conteudo = string.Format("Nome: {0}, Email: {1}, Assunto: {2}, Mensagem: {3} ", contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                // return new ContentResult() { Content =  conteudo };
                EnviarEmail.EnviarMensagemContato(contato);
                ViewBag.Mensagem = "Mensagem Enviada com Sucesso!!";
                return View("Index");
            }
            else
            {
                //não passou
                return View("Index");
            }
        }

        
    }
}
