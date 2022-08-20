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
using Newtonsoft.Json;

namespace SAISKabini
{
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmtpClient client = new SmtpClient();
            client.EnableSsl = false;
            client.Port = 25;
            client.Host = "10.0.3.63";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("sais@iski.istanbul", "Ss*2019");
            MailMessage mm = new MailMessage();

            mm.From = new MailAddress("sais@iski.istanbul");
            mm.To.Add("mertatmaca34@gmail.com");
            mm.Subject = "konu yok";
            mm.IsBodyHtml = true;
            mm.Body = "icerik";

            client.Send(mm);
            MessageBox.Show("Mail Gönderildi.");
        }
    }
}
