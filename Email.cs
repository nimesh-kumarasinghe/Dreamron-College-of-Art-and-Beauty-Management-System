using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EASendMail;

namespace Dreamron_College
{
    class Email
    {
        SmtpMail oMail = new SmtpMail("TryIt");
        public bool sendEmail()
        {
            try
            {
                oMail.From = "testdreamroncollege@yahoo.com";
                SmtpServer oServer = new SmtpServer("smtp.mail.yahoo.com");
                oServer.User = "testdreamroncollege@yahoo.com";
                oServer.Password = "vqgvfkdeowbuqrhe";
                oServer.Port = 465;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                Console.WriteLine("start to send email over SSL ...");
                EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                return true;
            }
            catch (Exception ep)
            {
                return false;
            }
        }
        public void to(String to)
        {
            oMail.To = to;
        }
        public void cc(String cc)
        {
            oMail.Cc = cc;
        }
        public void bcc(String bcc)
        {
            oMail.Bcc = bcc;
        }
        public void subject(String subject)
        {
            oMail.Subject = subject;
        }
        public void body(String body)
        {
            oMail.TextBody = body;
            
        }
        public void addAttachment(String loc)
        {
            oMail.AddAttachment(loc);
        }

        public bool employeeAccountCreated(String EmpID, String EIniName, String Email, String Password)
        {
            
            to(Email);
            subject("Account Created Successfully - Dreamron College of Art & Beauty");
            body(
                "Welcome To Dreamron College of Art & Beauty!" +
                "\n\n" +
                "Dear " + EIniName + "" +
                ",\n\nYour User ID : " + EmpID +
                "\nYour Password : " + Password + "" +
                "\n\nThanks & Best Regards," +
                "\nDreamron College of Art & Beauty Management.");
            bool status = sendEmail();
            return status;
        }
        public bool lecturerAccountCreated(String ID, String Email, String IniName)
        {
            to(Email);
            subject("Account Created Successfully - Dreamron College of Art & Beauty");
            body(
                "Welcome To Dreamron College of Art & Beauty!" +
                "\n\nDear " + IniName + "," +
                "\n\nYour User ID : " + ID + "" +
                "\n\nThanks & Best Regards," +
                "\nDreamron College of Art & Beauty Management.");
            bool status = sendEmail();
            return status;
        }
        public bool studentAccountCreated(String student_email, String student_id, String student_name_with_i)
        {
            to(student_email);
            subject("Welcome to Dreamron College of Art & Beauty");
            body(
                "Welcome To Dreamron College of Art & Beauty!" +
                "\n\nDear " + student_name_with_i + "," +
                "\n\nYour User ID : " + student_id +
                "\n\nThanks & Best Regards," +
                "\nDreamron College of Art & Beauty Management.");
            bool status = sendEmail();
            return status;
        }
    }
}
