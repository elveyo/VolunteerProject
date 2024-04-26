using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramZaVolontiranje
{
    public partial class MailForm : Form
    {
        private string? file;
        public MailForm()
        {
            InitializeComponent();
        }
        public MailForm(string attachment)
        {
            InitializeComponent();
            file = attachment;

        }

        private void MailForm_Load(object sender, EventArgs e)
        {
            tbPosiljalac.Text = "elviragic33@gmail.com";
            tbPrimatelj.Text = "elveyt44@gmail.com";
            tbPredmet.Text = $"Volonterski izvještaj za {DateTime.Now.Month}. mjesec.";
            lblDatoteka.Text = file;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            MailMessage message = new MailMessage(tbPosiljalac.Text, tbPrimatelj.Text);
            message.Subject = tbPredmet.Text;
            message.Body = rtbMail.Text;
            Attachment data = new Attachment(file);
            message.Attachments.Add(data);
            string password = "emja rfvp gpbf rjwu";

            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(tbPosiljalac.Text, password);
                client.EnableSsl = true;
                try
                {
                    client.Send(message);                 
                    MessageBox.Show("Email je uspješno poslan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            //fajl koji je poslan mailom je ostao otvoren pa se mora zatvoriti
            data.Dispose();
            File.Delete(file);

        }

  
    }
}
