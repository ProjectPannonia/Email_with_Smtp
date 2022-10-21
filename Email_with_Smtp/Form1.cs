using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Email_with_Smtp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strFromAddress = txtFromAddress.Text;
                string strToAddress = txtToAddress.Text;
                string strpwd = txtPwd.Text;
                string strBody = txtBody.Text;

                var smtpClient = new SmtpClient("smtp-mail.outlook.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(strFromAddress, strpwd),
                    EnableSsl = true,

                };

                smtpClient.Send(strFromAddress,strToAddress, "This is SMTP Demo", strBody);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
