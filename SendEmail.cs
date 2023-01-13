using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dreamron_College
{
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
        }
        Email em = new Email();
        private void btn_send_Click(object sender, EventArgs e)
        {
            int error = 0;
            if (string.IsNullOrEmpty(to.Text))
            {
                MessageBox.Show("Please enter a receiver email address");
                error = 1;
            }
            if (!Regex.IsMatch(to.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter a valid email address. Ex:name@gmail.com");
                error = 1;
            }
            if (bcc.Text.Length != 0)
            {
                if (!Regex.IsMatch(bcc.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid BCC email address. Ex:name@gmail.com");
                    error = 1;
                }
                else
                    em.bcc(bcc.Text);
            }
            if (cc.Text.Length != 0)
            {
                if (!Regex.IsMatch(cc.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                {
                    MessageBox.Show("Enter a valid CC email address. Ex:name@gmail.com");
                    error = 1;
                }
                else
                    em.cc(cc.Text);
            }
            if (string.IsNullOrEmpty(subject.Text))
            {
                MessageBox.Show("Please enter a subject");
                error = 1;
            }
            if (error == 0)
            {
                try
                {
                    em.to(to.Text);
                    em.subject(subject.Text);
                    em.body(body.Text);
                    em.sendEmail();
                    to.Clear(); cc.Clear(); bcc.Clear(); subject.Clear(); body.Clear(); file_location.Clear();
                    file_location.Visible = false;
                    MessageBox.Show("Email sent successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btn_attach_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    file_location.Visible = true;
                    file_location.Text = dlg.FileName.ToString();
                    em.addAttachment(file_location.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
