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

        // Double Variablen um die Koordinaten aus dem Hauptformular an dieses Form zu übergeben.
        public double yCoordinate;
        public double xCoordinate;


        private void btnShowOnMap_Click(object sender, EventArgs e)
        {
            ShowStationOnMap();
        }

        private void ShowMap_Load(object sender, EventArgs e)
        {
            mapControlStations.ShowCenter = false;
        }

        private void txtStation_TextChanged(object sender, EventArgs e)
        {
            Transport transport = new Transport();
            listStations.Visible = true;

            var stations = transport.GetStations(txtStation.Text).StationList;

            listStations.Items.Clear();

            for (int i = 0; i < (stations.Count - 1); i++)
            {
                try
                {
                    listStations.Items.Add(stations[i].Name);
                }
                catch
                {

                }
            }
        }

        private void listStations_DoubleClick(object sender, EventArgs e)
        {
            txtStation.Text = listStations.Text;
            listStations.Visible = false;
        }

        private void listStations_Click(object sender, EventArgs e)
        {
            txtStation.Text = listStations.Text;
            listStations.Visible = false;
        }

        private void txtStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listStations.SelectedIndex = 0;
                listStations.Focus();
            }
        }

        private void listStations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStation.Text = listStations.Text;
                listStations.Visible = false;
                ShowStationOnMap();
            }
        }

        // Zeigt den gewünschten Ort auf der Karte an. Um die Karte anzuzeigen wurde ein MapControll verwendet,
        // dass ich mit dem NuGet-Paket GMapControl hinzugefügt habe.
        private void ShowStationOnMap()
        {
            Transport transport = new Transport();
            string station = txtStation.Text;

            Stations stations;

            stations = transport.GetStations(station);

            mapControlStations.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            mapControlStations.Position = new PointLatLng(stations.StationList.First().Coordinate.XCoordinate, stations.StationList.First().Coordinate.YCoordinate);
            mapControlStations.MinZoom = 2;
            mapControlStations.MaxZoom = 18;
            mapControlStations.Zoom = 17;
            mapControlStations.CanDragMap = true;
            mapControlStations.ShowCenter = false;
            mapControlStations.DragButton = MouseButtons.Left;
        }
    }
}
