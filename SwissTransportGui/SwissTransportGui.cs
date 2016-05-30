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
            resetConnectionTable();
            resetDepartureTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transport = new Transport();
            dateFormatHelper = new DateFormatHelper();

            //Setting modes for autocomplete on TextBox
            textBoxFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxTo.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxTo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxStation.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxStation.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Connection list logic
        private void buttonSearchConnections_Click(object sender, EventArgs e)
        {
            searchConnections();
        }

        private void searchConnections()
        {
            //Clear table
            resetConnectionTable();

            //Getting start and destination String
            String start = textBoxFrom.Text;
            String destination = textBoxTo.Text;

            //Searching connection
            List<Connection> connections = transport.GetConnections(start, destination).ConnectionList;

            //Filling up the table with our results
            fillConnectionTable(connections);
        }

        private void fillConnectionTable(List<Connection> connections)
        {
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
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = departureText, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 0, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = arrivalText, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 1, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = durationText, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 2, row);
                tableLayoutPanelConnections.Controls.Add(new Label() { Text = platform, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 3, row);

                row++;
            }
        }

        private void resetConnectionTable()
        {
            //Emptying table
            tableLayoutPanelConnections.Controls.Clear();
            //Recreating headers
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Abfahrt", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 0, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Ankunft", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 1, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Dauer", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 2, 0);
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Gleis", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90}, 3, 0);
        }

        //Autocomplete listeners for TextBox
        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFrom.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxFrom.Text);
                textBoxFrom.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTo.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxTo.Text);
                textBoxTo.AutoCompleteCustomSource = autocompleteList;
            }
        }

        private void textBoxStation_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStation.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxStation.Text);
                textBoxStation.AutoCompleteCustomSource = autocompleteList;
            }
        }

        //Stationlist for autocomplete
        private AutoCompleteStringCollection searchStation(String query)
        {
            List<Station> stations = transport.GetStations(query).StationList;
            AutoCompleteStringCollection autocompleteList = new AutoCompleteStringCollection();
            foreach (Station station in stations){
                autocompleteList.Add(station.Name);
            }
            return autocompleteList;
        }

        //Departure list logic
        private void buttonSearchDepartures_Click(object sender, EventArgs e)
        {
            resetDepartureTable();

            List<Station> stations = transport.GetStations(textBoxStation.Text).StationList;
            if(stations.Count < 1)
            {
                return;
            }

            Station station = stations[0];
            StationBoardRoot stationBoardRoot = transport.GetStationBoard(station.Name, station.Id);
            List<StationBoard> stationBoards = stationBoardRoot.Entries;

            fillDepartureTable(stationBoards);
        }

        private void fillDepartureTable(List<StationBoard> stationBoards)
        {
            int row = 1;
            foreach (StationBoard stationBoard in stationBoards)
            {
                //Departure
                DateTime departure = stationBoard.Stop.Departure;
                String departureText = dateFormatHelper.convertIntToTimeString(departure.Hour) + ":" + dateFormatHelper.convertIntToTimeString(departure.Minute);

                //Destination
                String destinationText = stationBoard.To;



                //Platform
                String category = stationBoard.Category;

                //Adding values to table
                tableLayoutPanelDepartures.Controls.Add(new Label() { Text = departureText, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 0, row);
                tableLayoutPanelDepartures.Controls.Add(new Label() { Text = destinationText, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 1, row);
                tableLayoutPanelDepartures.Controls.Add(new Label() { Text = category, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 2, row);

                row++;
            }
        }

        private void resetDepartureTable()
        {
            //Emptying table
            tableLayoutPanelDepartures.Controls.Clear();
            //Recreating headers
            tableLayoutPanelDepartures.Controls.Add(new Label() { Text = "Abfahrt", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 0, 0);
            tableLayoutPanelDepartures.Controls.Add(new Label() { Text = "Ziel", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 1, 0);
            tableLayoutPanelDepartures.Controls.Add(new Label() { Text = "Typ", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 130 }, 2, 0);
        }
    }
}
