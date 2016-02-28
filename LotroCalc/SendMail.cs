using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.Configuration;
using System.Web.SessionState;


namespace LotroCalc
{


    public class SendMail
    {
        private string _subject;
        private string _body;
        private readonly List<MailAddress> _to = new List<MailAddress>();
        private readonly List<MailAddress> _bcc = new List<MailAddress>();

        private readonly List<MailAddress> _cc = new List<MailAddress>();
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }


        public void AddSendTo(string emailAddr)
        {
            _to.Add(new MailAddress(emailAddr));
        }


        public void AddSendTo(string emailAddr, string displayName)
        {
            _to.Add(new MailAddress(emailAddr, displayName));
        }


        public void AddCc(string emailAddr)
        {
            _cc.Add(new MailAddress(emailAddr));
        }


        public void AddCc(string emailAddr, string displayName)
        {
            _cc.Add(new MailAddress(emailAddr, displayName));
        }


        public void AddBcc(string emailAddr)
        {
            _bcc.Add(new MailAddress(emailAddr));
        }


        public void AddBcc(string emailAddr, string displayName)
        {
            _bcc.Add(new MailAddress(emailAddr, displayName));
        }


        public void SendSmtpEmail(bool isHtml)
        {
            // Create a new SmtpClient for sending the email
            var client = new SmtpClient("localhost");

            // Use the properties of the activity to construct a new MailMessage
            var message = new MailMessage();

            message.From = new MailAddress("recipes@craftingcalc.com", "Recipe Submission");
            //message.ReplyTo = message.From

            message.To.Clear();
            message.CC.Clear();
            message.Bcc.Clear();

            foreach (MailAddress toAddr in _to)
            {
                message.To.Add(toAddr);
            }

            foreach (MailAddress ccAddr in _cc)
            {
                message.CC.Add(ccAddr);
            }

            message.IsBodyHtml = isHtml;

            if (!string.IsNullOrEmpty(_subject))
                message.Subject = _subject;

            if (!string.IsNullOrEmpty(_body))
            {
                message.Body = _body;

                //client.UseDefaultCredentials = false;

               // string account = ConfigurationManager.AppSettings["Account"];
                //string pwd = ConfigurationManager.AppSettings["Pwd"];

                //client.Credentials = new NetworkCredential(account, pwd);

                client.Send(message);

            }
        }
    }
}