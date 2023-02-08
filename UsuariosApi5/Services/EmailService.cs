using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using UsuariosApi5.Models;

namespace UsuariosApi5.Services
{
    public class EmailService
    {
        private IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void EnviarEmail(string[] destinatario, string assunto, int usuarioId, string code)
        {
            Mensagem mensagem = new Mensagem(destinatario, assunto, usuarioId, code);
            var mensagemDeEmail = CriaCorpoDoEmail(mensagem);
            Enviar(mensagemDeEmail);
        }

        private void Enviar(MimeMessage mensagemDeEmail)
        {
            string smtpServer = _configuration.GetValue<string>("EmailSettings:SmtpServer");
            int port = _configuration.GetValue<int>("EmailSettings:Port");
            string userName = _configuration.GetValue<string>("EmailSettings:Username");
            string password = _configuration.GetValue<string>("EmailSettings:Password");

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(smtpServer,
                        port, false);
                    client.AuthenticationMechanisms.Remove("XOUATH2");
                    client.Authenticate(userName, 
                        password);
                    client.Send(mensagemDeEmail);
                }
                catch
                {
                    throw;
                }
                finally 
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private MimeMessage CriaCorpoDoEmail(Mensagem mensagem)
        {
            var mensagemDeEmail = new MimeMessage();
            mensagemDeEmail.From.Add(new MailboxAddress(_configuration.GetValue<string>("EmailSettings:From")));
            mensagemDeEmail.To.AddRange(mensagem.Destinatario);
            mensagemDeEmail.Subject = mensagem.Assunto;
            mensagemDeEmail.Body = new TextPart(MimeKit.Text.TextFormat.Text)
            {
                Text = mensagem.Conteudo
            };

            return mensagemDeEmail;
        }
    }
}
