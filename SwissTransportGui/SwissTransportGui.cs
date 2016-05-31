using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
        GMapOverlay markersOverlay = new GMapOverlay("markers");
        GMarkerGoogle stationMarker;

        public SwissTransportGui()
        {
            InitializeComponent();
            resetConnectionTable();
            resetDepartureTable();
            initializeMap();
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

            textBoxStationSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxStationSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void initializeMap()
        {
            //Setting initial map configs
            map.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            map.Overlays.Add(markersOverlay);
            map.ShowCenter = false;
            map.Position = new PointLatLng(46.7976691, 8.2275602);
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
            DateTime date = dateTimePickerDate.Value;
            DateTime time = dateTimePickerTime.Value;
            DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, 0);

            //Searching connection
            List<Connection> connections = transport.GetConnections(start, destination, dateTime).ConnectionList;

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
                String durationText = duration.ToString("HH:mm");

                //Departure
                DateTime departure = Convert.ToDateTime(connection.From.Departure.ToString());
                String departureText = departure.ToString("HH:mm");

                //Arrival
                DateTime arrival = Convert.ToDateTime(connection.To.Arrival.ToString());
                String arrivalText = departure.ToString("HH:mm");

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
            tableLayoutPanelConnections.Controls.Add(new Label() { Text = "Gleis", AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Dock = DockStyle.None, Width = 90 }, 3, 0);
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

        private void textBoxStationSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxStationSearch.Text.Length > 2)
            {
                AutoCompleteStringCollection autocompleteList = searchStation(textBoxStationSearch.Text);
                textBoxStationSearch.AutoCompleteCustomSource = autocompleteList;
            }
        }

        //Stationlist for autocomplete
        private AutoCompleteStringCollection searchStation(String query)
        {
            List<Station> stations = transport.GetStations(query).StationList;
            AutoCompleteStringCollection autocompleteList = new AutoCompleteStringCollection();
            foreach (Station station in stations)
            {
                autocompleteList.Add(station.Name);
            }
            return autocompleteList;
        }

        //Departure list logic
        private void buttonSearchDepartures_Click(object sender, EventArgs e)
        {
            //Reseting table
            resetDepartureTable();
            //Getting station name from gui
            String stationName = textBoxStation.Text;

            //Search station by name
            List<Station> stations = transport.GetStations(stationName).StationList;
            if (stations.Count < 1)
            {
                return;
            }
            Station station = stations[0];

            //Requesting station board for entered station
            StationBoardRoot stationBoardRoot = transport.GetStationBoard(station.Name, station.Id);
            List<StationBoard> stationBoards = stationBoardRoot.Entries;

            //Filling up list with data from station board
            fillDepartureTable(stationBoards);
        }

        private void fillDepartureTable(List<StationBoard> stationBoards)
        {
            int row = 1;
            foreach (StationBoard stationBoard in stationBoards)
            {
                //Departure
                DateTime departure = stationBoard.Stop.Departure;
                String departureText = departure.ToString("HH:mm");

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

        private void buttonSearchStation_Click(object sender, EventArgs e)
        {
            //Getting station name from gui
            String stationName = textBoxStationSearch.Text;

            //Searching station by name
            List<Station> stations = transport.GetStations(stationName).StationList;
            if (stations.Count < 1)
            {
                return;
            }
            Station station = stations[0];

            //Removing old marker
            markersOverlay.Markers.Remove(stationMarker);
            //Adding new marker
            stationMarker = new GMarkerGoogle(new PointLatLng(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate),
            GMarkerGoogleType.red_dot);
            markersOverlay.Markers.Add(stationMarker);
            //Setting map position and zoom
            map.Position = new PointLatLng(station.Coordinate.XCoordinate, station.Coordinate.YCoordinate);
            map.Zoom = 15;
        }
    }
}
