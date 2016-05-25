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
            resetTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transport = new Transport();
            dateFormatHelper = new DateFormatHelper();
        }

        private void buttonSearchConnections_Click(object sender, EventArgs e)
        {
            searchConnections();
        }

        private void searchConnections()
        {
            String start = textBoxFrom.Text;
            String destination = textBoxTo.Text;

            //Searching connection
            List<Connection> connections = transport.GetConnections(start, destination).ConnectionList;

            resetTable();

            int row = 1;
            foreach (Connection connection in connections)
            {
                //Duration
                DateTime duration = dateFormatHelper.convertDuration(connection.Duration);
                String durationText = dateFormatHelper.convertIntToTimeString(duration.Hour) + ":" + dateFormatHelper.convertIntToTimeString(duration.Minute);

                //Departure
                DateTime departure = Convert.ToDateTime(connection.From.Departure.ToString());
                String departureText = dateFormatHelper.convertIntToTimeString(departure.Hour) + ":" + dateFormatHelper.convertIntToTimeString(departure.Minute);

                //Arrival
                DateTime arrival = Convert.ToDateTime(connection.To.Arrival.ToString());
                String arrivalText = dateFormatHelper.convertIntToTimeString(arrival.Hour) + ":" + dateFormatHelper.convertIntToTimeString(arrival.Minute);

                //Platform
                String platform = connection.From.Platform;

                //Adding values to table
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = departureText }, 0, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = arrivalText }, 1, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = durationText }, 2, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = platform }, 3, row);

                row++;
            }
        }

        private void resetTable()
        {
            tableLayoutPanelConnections.Controls.Clear();
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Abfahrt" }, 0, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Ankunft" }, 1, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Dauer" }, 2, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Gleis" }, 3, 0);
        }

        private AutoCompleteStringCollection searchStation(String query)
        {
            List<Station> stations = transport.GetStations(query).StationList;
            AutoCompleteStringCollection autocompleteList = new AutoCompleteStringCollection();
            foreach (Station station in stations){
                autocompleteList.Add(station.Name);
            }
            return autocompleteList;
        }

        private void textBoxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchConnections();
            }
        }

        private void textBoxTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchConnections();
            }
        }

        private void buttonSearchFrom_Click(object sender, EventArgs e)
        {
            AutoCompleteStringCollection autocompleteList = searchStation(textBoxFrom.Text);
            textBoxFrom.AutoCompleteCustomSource = autocompleteList;
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            if(textBoxFrom.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxFrom.Text);
                textBoxFrom.AutoCompleteCustomSource = autocompleteList;
                textBoxFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBoxFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTo.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxTo.Text);
                textBoxTo.AutoCompleteCustomSource = autocompleteList;
                textBoxTo.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBoxTo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
    }
}
