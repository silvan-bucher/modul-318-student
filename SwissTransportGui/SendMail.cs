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

namespace SwissTransportGui
{
    public partial class SendMail : Form
    {
        TableLayoutPanel table;
        String from;
        String to;
        public SendMail(TableLayoutPanel table, String from, String to)
        {
            this.table = table;
            this.from = from;
            this.to = to;
            InitializeComponent();
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            String addressee = textBoxAddressee.Text;
            MailAddress fromAddress = new MailAddress("swisstransport318@gmail.com", "Swiss Transport");
            String fromPassword = "hey123abc";
            MailAddress toAddress = new MailAddress(addressee);
            String subject = "Fahrplan von SwissTransport";
            String body = "<h1>Swiss Transport</h1><p>Dies sind die Verbindungen von " + from + " nach " + to + "." + getHtmlTableCodeConnections() + "<p>Greetings, Swiss Transport</p>";


            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }

            this.Close();
        }

        private String getHtmlTableCodeConnections()
        {
            String tableHtml = "";
            int currentRow = 0;
            foreach (Control c in this.table.Controls)
            {
                if (currentRow != this.table.GetRow(c))
                {
                    currentRow = this.table.GetRow(c);
                    tableHtml += "</tr>";
                    tableHtml += "<tr>";
                    tableHtml += "<td>" + c.Text + "</td>";
                    continue;
                }
                tableHtml += "<td>" + c.Text + "</td>";
            }
            tableHtml = "<table border=\"1\"><tr>" + tableHtml + "</tr></table>";
            return tableHtml;
        }
    }
}
