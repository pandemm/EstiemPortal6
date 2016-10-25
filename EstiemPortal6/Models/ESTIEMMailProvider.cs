using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace EstiemPortal6.Models
{
    public class ESTIEMMailProvider
    {
        public static void SendEmail(MailMessage message)
        {
            SmtpClient c = new SmtpClient(/*INSERT SMTP DETAILS HERE*/);
            message.Subject = string.Format("[ESTIEM] {0}", message.Subject);
            if (message.Sender == null || string.IsNullOrEmpty(message.Sender.Address))
            {
                message.Sender = new MailAddress("a"/*INSERT SMTP DETAILS HERE*/);
            }
            message.From = new MailAddress("a"/*INSERT SMTP DETAILS HERE*/);
            c.Send(message);
        }
    }
}