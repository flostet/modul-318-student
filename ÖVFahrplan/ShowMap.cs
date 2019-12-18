using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using SwissTransport;

namespace ÖVFahrplan
{
    public partial class ShowMap : Form
    {
        public ShowMap()
        {
            InitializeComponent();
        }

        // Standardort und Koordinaten sind Luzern Bahnhof
        // Double Variablen um die Koordinaten aus dem Hauptformular an dieses Form zu übergeben.
        public double yCoordinate = 8.3093072;
        public double xCoordinate = 47.0501682;
        // Speichert den Namen der Station um es in der TextBox(txtStation) anzuzeigen
        public string CityName = "Luzern";

        // Ruft eine Methode an um die Station auf der Karte anzuzeigen
        private void btnShowOnMap_Click(object sender, EventArgs e)
        {
            ShowStationOnMapName();
        }

        // Beim Laden des Formulars wird die Methode um eine Station auf der Karte anzuzeigen aufgerufen
        private void ShowMap_Load(object sender, EventArgs e)
        {
            mapControlStations.ShowCenter = false;

                showStationOnMapCoordinates();
        }

        // Ist für AutoCompletion. Bei jeder Textänderung in TextBox(txtStation) wird die Liste frisch in die
        // ListBox (listStations) geschrieben.
        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Transport transport = new Transport();
                listStations.Visible = true;

                var stations = transport.GetStations(txtStation.Text).StationList;

                listStations.Items.Clear();

                for (int i = 0; i < (stations.Count - 1); i++)
                {
                    try
                    {
                        // Stationsvorschläge werden der ListBox hinzugefügt
                        listStations.Items.Add(stations[i].Name);
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {
            }
        }

        // Bei Doppelklick in ListBox(listStations) wird selektiertes Element in TextBox(txtStation) geschrieben.
        private void listStations_DoubleClick(object sender, EventArgs e)
        {
            txtStation.Text = listStations.Text;
            listStations.Visible = false;
        }

        // Ausgewähltes Element in ListBox(listStations) wird in TextBox(txtStation) geschrieben
        private void listStations_Click(object sender, EventArgs e)
        {
            txtStation.Text = listStations.Text;
            listStations.Visible = false;
        }

        // Sobald Arrow Key nach unten in TextBox(txtStation) gedrückt wird, springt Focus auf ListBox(listStations) und
        // erstes Element darin wird selektiert.
        private void txtStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listStations.SelectedIndex = 0;
                listStations.Focus();
            }
        }

        // Wenn Enter Key in ListBox(listStations) gedrückt wird, wird ausgewählter Text in TextBox(txtStation) geschrieben und ListBox ausgeblendet.
        private void listStations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStation.Text = listStations.Text;
                listStations.Visible = false;
                ShowStationOnMapName();
            }
        }

        // Zeigt den gewünschten Ort auf der Karte an. Um die Karte anzuzeigen wurde ein MapControl verwendet,
        // dass ich mit dem NuGet-Paket GMapControl hinzugefügt habe. Dafür wird der Name der Station verwendet
        private void ShowStationOnMapName()
        {
            try
            {
                Transport transport = new Transport();
                string station = txtStation.Text;

                Stations stations;

                stations = transport.GetStations(station);

                mapControlStations.MapProvider = GoogleMapProvider.Instance;
                GMaps.Instance.Mode = AccessMode.ServerOnly;

                // Überprüfen ob leere Koordinaten übergeben wurden
                if (stations.StationList.First().Coordinate.XCoordinate != 0)
                {
                    // Koordinaten dem mapControl übergeben
                    mapControlStations.Position = new PointLatLng(stations.StationList.First().Coordinate.XCoordinate, stations.StationList.First().Coordinate.YCoordinate);
                    mapControlStations.MinZoom = 2;
                    mapControlStations.MaxZoom = 18;
                    mapControlStations.Zoom = 17;
                    mapControlStations.CanDragMap = true;
                    mapControlStations.ShowCenter = false;
                    mapControlStations.DragButton = MouseButtons.Left;
                }
                else
                {
                    MessageBox.Show("Station kann nicht auf Karte angezeigt werden");
                }
            }
            catch
            {
                MessageBox.Show("Station kann nicht auf Karte angezeigt werden.");
            }
        }

        // Zeigt den gewünschten Ort auf der Karte an. Um die Karte anzuzeigen wurde ein MapControl verwendet,
        // dass ich mit dem NuGet-Paket GMapControl hinzugefügt habe. Dafür werden die Koordinaten der Station verwendet
        private void showStationOnMapCoordinates()
        {
            try
            {
                mapControlStations.MapProvider = GoogleMapProvider.Instance;
                GMaps.Instance.Mode = AccessMode.ServerOnly;
                // Überprüfen, ob leere Koordinaten übergeben wurden
                if (xCoordinate != 0)
                {
                    mapControlStations.Position = new PointLatLng(xCoordinate, yCoordinate);
                    mapControlStations.MinZoom = 2;
                    mapControlStations.MaxZoom = 18;
                    mapControlStations.Zoom = 17;
                    mapControlStations.CanDragMap = true;
                    mapControlStations.ShowCenter = false;
                    mapControlStations.DragButton = MouseButtons.Left;
                    txtStation.Text = CityName;
                    listStations.Visible = false;
                }
                else
                {
                    MessageBox.Show("Station kann nicht auf Karte angezeigt werden.");
                }
            }
            catch
            {
                MessageBox.Show("Station kann nicht auf Karte angezeigt werden.");
            }
        }
    }
}
