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
        ITransport transport;
        DateFormatHelper dateFormatHelper;
        public SwissTransportGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transport = new Transport();
            dateFormatHelper = new DateFormatHelper();
            //ITransport testee = new Transport();
            //var connections = testee.GetConnections("Sursee", "Luzern");

            //label1.Text = connections.ConnectionList[0].To.Station.Name;
        }

        private void buttonSearchConnections_Click(object sender, EventArgs e)
        {
            String start = textBoxFrom.Text;
            String destination = textBoxTo.Text;

            //Searching connection
            List<Connection> connections = transport.GetConnections(start, destination).ConnectionList;
            int row = 0;
            foreach (Connection connection in connections)
            {
                //Duration
                DateTime duration = dateFormatHelper.convertDuration(connection.Duration);
                String durationText = Convert.ToString(duration.Hour) + ":" + Convert.ToString(duration.Minute);

                //Departure
                DateTime departure = Convert.ToDateTime(connection.From.Departure.ToString());
                String departureText = Convert.ToString(departure.Hour + ":" + departure.Minute);

                //Arrival
                DateTime arrival = Convert.ToDateTime(connection.To.Arrival.ToString());
                String arrivalText = Convert.ToString(arrival.Hour + ":" + arrival.Minute);

                //Adding values to table
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = departureText }, 0, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = arrivalText }, 1, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = durationText }, 2, row);

                row++;
            }
        }
    }
}
