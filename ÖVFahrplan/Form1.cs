using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace ÖVFahrplan
{
    public partial class Form1 : Form
    {
        private Transport transport;
        private Stations stations;

        private Connections connections;
        private StationBoardRoot verbindungen;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            if (txtDeparture.Text != String.Empty && txtDestination.Text == string.Empty && txtTime.Text != string.Empty)
            {
                transport = new Transport();
                verbindungen = transport.GetStationBoard(txtDestination.Text, "");
                listView1.Clear();

                for (int i = 0; i <= 5; i++)
                {
                    ListViewItem item1 = new ListViewItem();

                    string departureTime = verbindungen.Entries[i].Stop.Departure.TimeOfDay + "";
                    item1.Text = departureTime;

                    string trainNumber = verbindungen.Entries[i].Category + " " + verbindungen.Entries[i].Number;
                    item1.SubItems.Add(trainNumber);

                    string duration = verbindungen.Entries[i].To;
                    item1.SubItems.Add(duration);

                    listView1.Items.Add(item1);
                }
            }
            else if(txtDeparture.Text != String.Empty && txtDestination.Text != String.Empty && txtTime.Text != string.Empty)
            {
                transport = new Transport();
                connections = transport.GetConnections(txtDeparture.Text, txtDestination.Text, datePicker.Text, txtTime.Text);
                verbindungen = transport.GetStationBoard(txtDeparture.Text, "");
                listView1.Clear();

                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem();

                    string depatureTime = connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) + " -> " + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8);
                    item1.Text = depatureTime;

                    string trainNumber = verbindungen.Entries[1].Category + " " + verbindungen.Entries[i].Number;
                    item1.SubItems.Add(trainNumber);

                    string duration = connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3) + " min";
                    item1.SubItems.Add(duration);

                    listView1.Items.Add(item1);
                }
            }
            else
            {
                MessageBox.Show("Bitte korrekte Daten eingeben.");
            }
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();

            stations = new Stations();
            transport = new Transport();

            stations = transport.GetStations(txtDeparture.Text);

            foreach (Station station in stations.StationList)
            {
                liste.Add(station.Name);
            }

            txtDeparture.AutoCompleteCustomSource.AddRange(liste.ToArray());
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            List<string> liste = new List<string>();

            stations = new Stations();
            transport = new Transport();

            stations = transport.GetStations(txtDeparture.Text);

            foreach (Station station in stations.StationList)
            {
                liste.Add(station.Name);
            }

            txtDeparture.AutoCompleteCustomSource.AddRange(liste.ToArray());
        }
    }
}
