using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Post_Client : Form
    {
        public Post_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(UsersEmail.Text, UsersNameLabel.Text);
            MailAddress to = new MailAddress(RecipientsEmail.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = SubjectLabel.Text;
            m.Body = Message.Text;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(UsersEmail.Text, UsersPassword.Text);
            smtp.EnableSsl = true;
            smtp.Send(m);
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void RecipientsEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
