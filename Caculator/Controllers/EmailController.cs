using Caculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace Caculator.Controllers
{
    public class EmailController : Controller
    {
        private readonly IConfiguration _config;

        public EmailController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View("Send_Email");
        }
        public IActionResult Send_Email(MailInfo model)
        {
            var host = _config["MailSettings:Host"];
            var port = int.Parse(_config["MailSettings:Port"]);
            var user = _config["MailSettings:User"];
            var pass = _config["MailSettings:Password"];

            var mail = new SmtpClient(host,port)
            {
                Credentials = new NetworkCredential(user,pass),
                EnableSsl = true
            }; 

            //tạo email
            var message = new MailMessage();
            message.From = new MailAddress(model.From);
            message.ReplyToList.Add(model.From);
            message.To.Add(new MailAddress(model.To));
            message.Subject = model.Subject;
            message.Body = model.Body;

            //gửi mail
            mail.Send(message);
            return View();
        }
    }
}
