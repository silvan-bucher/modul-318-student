using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGui
{
    public partial class SwissTransportGui : Form
    {
        public SwissTransportGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ITransport testee = new Transport();
            //var connections = testee.GetConnections("Sursee", "Luzern");

            //label1.Text = connections.ConnectionList[0].To.Station.Name;
        }

        private void buttonSearchConnections_Click(object sender, EventArgs e)
        {

        }
    }
}
