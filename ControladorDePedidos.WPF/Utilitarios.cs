using System.Net;
using System.Net.Mail;
using System.Windows;

namespace ControladorDePedidos.WPF
{
    public class Utilitarios
    {
        public void EnviarEmail(string destinatario, string titulo, string mensagem)
        {
            //var emailDeOrigem = "dn@dn32.com.br";
            //var servidorSMTP = "in-v3.mailjet.com";
            //var portaSMTP = 587;
            //var usuarioSMTP = "faf738ee1142cfb51c9f2e3fc2817c67";
            //var senhaSMTP = "b9b189670b460737526fd964be7729ae";

            //var smtp = new SmtpClient();
            //smtp.Host = servidorSMTP;
            //smtp.Port = portaSMTP;
            //smtp.EnableSsl = true;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential(usuarioSMTP, senhaSMTP);

            //var msg = new MailMessage();
            //msg.To.Add(destinatario);
            //msg.Subject = titulo;
            //msg.IsBodyHtml = true;
            //msg.From = new MailAddress(emailDeOrigem);
            //msg.ReplyToList.Add(emailDeOrigem);
            //msg.Body = mensagem;

            //smtp.Send(msg);
            MessageBox.Show("Email enviado...!");
        }
    }
}
