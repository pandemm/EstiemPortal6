using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using EstiemPortal6.Repositories;
using EstiemPortal6.Models;

namespace EstiemPortal6.Emails
{
    public class Emails
    {
        private MailMessage EventCreationMail(Event ev, User eventcreator)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("vp-activities@estiem.org");
            mail.IsBodyHtml = true;
            mail.Subject = "Event has been created: " + ev.Name;
            StringBuilder body = new StringBuilder();
            body.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\"><html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=Windows-1252\"></head>");
            body.Append("<body>");
            body.AppendFormat("<p>The following Event has been created by {0}:</p>", eventcreator.UserName);
            body.Append("<ul>");
            body.AppendFormat("<li><em>Name:</em> {0}.", ev.Name);
            body.AppendFormat("<li><em>Place:</em> {0}</li>", ev.Place);
            body.AppendFormat("<li><em>Date:</em> {0} to {1}</li>", ev.StartDate.ToString("d MMMM yyyy"), ev.EndDate.ToString("d MMMM yyyy"));
            // Check out the next line and think through if you want CancellationDeadLine to be nullable
            //body.AppendFormat("<li><em>Cancellation deadline:</em> {0}</li>", ev.CancellationDeadLine.ToString("d MMMM yyyy"));
            body.Append("<p>Your IT Committee</p>");
            body.Append("</body>");
            body.Append("</html>");
            mail.Body = body.ToString();
            return mail;
        }

        private MailMessage ApplicationMail(EventParticipant evp)
        {
            MailMessage mail = new MailMessage();
            //mail.To.Add(user.Email);
            // Get EventAdmin to cc him in the email
            // CC Local Responsible of the Organising LG
            // BCC VP of Administration
            mail.Bcc.Add("vp-activities@estiem.org");
            // Write the email
            mail.IsBodyHtml = true;
            mail.Subject = "You have applied for: " + evp.Event.Name;
            StringBuilder body = new StringBuilder();
            body.Append("<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\"><html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=Windows-1252\"></head>");
            body.Append("<body>");
            body.AppendFormat("<p>Dear {0},</p>", evp.Participant.FirstNameEnglish);
            body.Append("<p>You have applied for the following event:</p>");
            body.Append("<ul>");
            body.AppendFormat("<li><em>Name:</em> {0}.", evp.Event.Name);
            body.AppendFormat("<li><em>Place:</em> {0}</li>", evp.Event.Place);
            body.AppendFormat("<li><em>Date:</em> {0} to {1}</li>", evp.Event.StartDate.ToString("d MMMM yyyy"), evp.Event.EndDate.ToString("d MMMM yyyy"));
            // Should cancellationdeadline be nullable?
            //body.AppendFormat("<li><em>Cancellation deadline:</em> {0}</li>", evp.Event.RetireDeadline.ToString("d MMMM yyyy"));
            if (!String.IsNullOrWhiteSpace(evp.Event.Email))
                body.AppendFormat("<li><em>Contact:</em> {0}</li>", evp.Event.Email);
            body.Append("</ul>");
            body.Append("<p>Please note that you still need to get registered in order to go to the event. If there are more applicants than vacant places, not everyone will have the possibility to attend.</p>");
            body.Append("<p>Your IT Committee</p>");
            //body.AppendFormat("<p><em>This email was sent after actions made by {0}. If you receive it by a mistake, please contact <a href=\"help.it@estiem.org\">help.it@estiem.org</a>.</p>", CurrentUser.UserName);
            body.Append("</body>");
            body.Append("</html>");
            mail.Body = body.ToString();
            return mail;
        }
        
        private void RegistrationMail()
        {

        }

        private void CancellationMail()
        {
                
        }

        private void DidNotShowUpMail()
        {

        }
    }
}