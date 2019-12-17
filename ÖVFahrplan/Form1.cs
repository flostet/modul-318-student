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
            radioBtnConnectionsPlan.Checked = true;
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            listDeparture.Visible = false;
            listDestination.Visible = false;

            try
            {
                listView1.Items.Clear();

                if (radioBtnConnectionsPlan.Checked)
                {
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
                else if (radioBtnDeparturePlan.Checked)
                {
                    transport = new Transport();

                    verbindungen = transport.GetStationBoard(txtDeparture.Text, "");

                    for (int i = 0; i < 5; i++)
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = txtDeparture.Text;

                        string ToStation = verbindungen.Entries[i].To;
                        item.SubItems.Add(ToStation);

                        string connectionTime = verbindungen.Entries[i].Stop.Departure.TimeOfDay.ToString();
                        item.SubItems.Add(connectionTime);

                        string trainNumber = verbindungen.Entries[i].Category + " " + verbindungen.Entries[i].Number;
                        item.SubItems.Add(trainNumber);

                        listView1.Items.Add(item);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Es wurden keine Verbindungen gefunden\nVersuchen Sie es noch einmal!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDeparture_TextChanged(object sender, EventArgs e)
        {
            transport = new Transport();
            listDeparture.Visible = true;

            var stations = transport.GetStations(txtDeparture.Text).StationList;

            listDeparture.Items.Clear();

            for (int i = 0; i < (stations.Count - 1); i++)
            {
                try
                {
                    listDeparture.Items.Add(stations[i].Name);
                }
                catch
                {
                    
                }
            }
        }

        private void txtDestination_TextChanged(object sender, EventArgs e)
        {
            transport = new Transport();
            listDestination.Visible = true;

            var stations = transport.GetStations(txtDestination.Text).StationList;

            listDestination.Items.Clear();

            for (int i = 0; i < (stations.Count - 1); i++)
            {
                try
                {
                    listDestination.Items.Add(stations[i].Name);
                }
                catch
                {

                }
            }
        }

        private void listDeparture_DoubleClick(object sender, EventArgs e)
        {
            txtDeparture.Text = listDeparture.SelectedItem.ToString();
            listDeparture.Visible = false;
        }

        private void listDestination_DoubleClick(object sender, EventArgs e)
        {
            txtDestination.Text = listDestination.SelectedItem.ToString();
            listDestination.Visible = false;
        }

        private void txtDeparture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listDeparture.SelectedIndex = 0;
                listDeparture.Focus();
            }
        }

        private void txtDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listDestination.SelectedIndex = 0;
                listDestination.Focus();
            }
        }

        private void listDeparture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDeparture.Text = listDeparture.Text;
                listDeparture.Visible = false;
            }
        }

        private void listDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDestination.Text = listDestination.Text;
                listDestination.Visible = false;
            }
        }

        private void radioBtnConnectionsPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnConnectionsPlan.Checked)
            {
                txtDestination.Enabled = true;
                btnSearchConnection.Text = "Verbindung suchen";
                txtTime.Enabled = true;
                datePicker.Enabled = true;

                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Von", 100);
                listView1.Columns.Add("Nach", 100);
                listView1.Columns.Add("Zeit", 110);
                listView1.Columns.Add("Zug/Bus Nr", 100);
                listView1.Columns.Add("Dauer", 60);

            }
            else if (radioBtnDeparturePlan.Checked)
            {
                txtDestination.Enabled = false;
                btnSearchConnection.Text = "Abfahrt suchen";
                txtTime.Enabled = false;
                datePicker.Enabled = false;

                listView1.Items.Clear();
                listView1.Columns.Clear();
                listView1.Columns.Add("Von", 100);
                listView1.Columns.Add("Nach", 100);
                listView1.Columns.Add("Zeit", 110);
                listView1.Columns.Add("Zug/Bus Nr.", 100);
            }
        }

        // Wenn auf ein Element in der ListBox(listDeparture) auf eine Zeile geklickt wird, erscheint es in der TextBox(txtDeparture)
        private void listDeparture_Click(object sender, EventArgs e)
        {
            txtDeparture.Text = listDeparture.Text;
            listDeparture.Visible = false;
        }

        private void listDestination_Click(object sender, EventArgs e)
        {
            txtDestination.Text = listDestination.Text;
            listDestination.Visible = false;
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            listDeparture.Visible = false;
            listDestination.Visible = false;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSendMail.Enabled = true;
        }
    }
}
