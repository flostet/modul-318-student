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
            txtDeparture.Focus();
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (txtDeparture.Text == String.Empty || txtDestination.Text == String.Empty || txtTime.Text == String.Empty)
            {
                MessageBox.Show("Bitte korrekte Daten eingeben.");
            }
            else
            {
                transport = new Transport();
                connections = transport.GetConnections(txtDeparture.Text, txtDestination.Text, datePicker.Text, txtTime.Text);
                verbindungen = transport.GetStationBoard(txtDeparture.Text, "");

                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    ListViewItem item1 = new ListViewItem();

                    item1.Text = txtDeparture.Text;
                    item1.SubItems.Add(txtDestination.Text);


                    string depatureTime = connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) +
                                          " - " + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8);
                    item1.SubItems.Add(depatureTime);

                    string trainNumber = verbindungen.Entries[1].Category + " " + verbindungen.Entries[i].Number;
                    item1.SubItems.Add(trainNumber);

                    string duration = connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3) + " min";
                    item1.SubItems.Add(duration);

                    listView1.Items.Add(item1);
                }
            } 
        }

        // Bei jeder Änderung im Textfeld wird die Liste mit den Station frisch geladen und 
        // Stationsvorschläge werden in der ComboBox angezeigt (Auto Complete)
        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            try
            {
                transport = new Transport();
                txtDestination.DroppedDown = true;
                Cursor.Current = Cursors.Default;

                for (int i = txtDestination.Items.Count - 1; i >= 0; i--)
                    txtDestination.Items.RemoveAt(i);

                int count = 0;
                var stations = transport.GetStations(txtDestination.Text).StationList;
                for (int i = 0; i < stations.Count; i++)
                {
                    txtDestination.Items.Add(stations[i].Name);
                    count++;
                }

                int p = txtDestination.Items.Count - count;
            }
            catch
            {
                
            }
        }

        // Bei jeder Änderung im Textfeld wird die Liste mit den Station frisch geladen und 
        // Stationsvorschläge werden in der ComboBox angezeigt (Auto Complete)
        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            try
            {
                transport = new Transport();

                txtDeparture.DroppedDown = true;
                Cursor.Current = Cursors.Default;

                for (int i = txtDeparture.Items.Count - 1; i >= 0; i--)
                    txtDeparture.Items.RemoveAt(i);

                var stations = transport.GetStations(txtDeparture.Text).StationList;
                for (int i = 0; i < stations.Count; i++)
                {
                    txtDeparture.Items.Add(stations[i].Name);
                }
            }
            catch
            {
               
            }
            
        }

        private void cbStation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                transport = new Transport();

                cbStation.DroppedDown = true;
                Cursor.Current = Cursors.Default;

                for (int i = cbStation.Items.Count - 1; i >= 0; i--)
                    cbStation.Items.RemoveAt(i);

                var stations = transport.GetStations(cbStation.Text).StationList;
                for (int i = 0; i < stations.Count; i++)
                {
                    cbStation.Items.Add(stations[i].Name);
                }
            }
            catch
            {
                
            }
        }

        private void btnShowConnections_Click(object sender, EventArgs e)
        {
            transport = new Transport();
            verbindungen = transport.GetStationBoard(cbStation.Text, "");
            for (int i = 0; i < 5; i++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = cbStation.Text;
                item.SubItems.Add("");

                string departureTime = verbindungen.Entries[i].Stop.Departure.TimeOfDay + "";
            }
        }
    }
}
