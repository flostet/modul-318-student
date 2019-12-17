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
    public partial class Fahrplan : Form
    {
        private Transport transport;
        private Stations stations;

        private Connections connections;
        private StationBoardRoot verbindungen;

        public Fahrplan()
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
                listViewConnections.Items.Clear();

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
                            ListViewItem connectionsListItem = new ListViewItem();

                            connectionsListItem.Text = txtDeparture.Text;
                            connectionsListItem.SubItems.Add(txtDestination.Text);


                            string depatureTime = connections.ConnectionList[i].From.Departure.Remove(0, 11).Remove(5, 8) +
                                                  " - " + connections.ConnectionList[i].To.Arrival.Remove(0, 11).Remove(5, 8);
                            connectionsListItem.SubItems.Add(depatureTime);

                            string trainNumber = verbindungen.Entries[1].Category + " " + verbindungen.Entries[i].Number;
                            connectionsListItem.SubItems.Add(trainNumber);

                            string duration = connections.ConnectionList[i].Duration.Remove(0, 3).Remove(5, 3) + " min";
                            connectionsListItem.SubItems.Add(duration);

                            listViewConnections.Items.Add(connectionsListItem);
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

                        listViewConnections.Items.Add(item);
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

                listViewConnections.Items.Clear();
                listViewConnections.Columns.Clear();
                listViewConnections.Columns.Add("Von", 100);
                listViewConnections.Columns.Add("Nach", 100);
                listViewConnections.Columns.Add("Zeit", 110);
                listViewConnections.Columns.Add("Zug/Bus Nr", 100);
                listViewConnections.Columns.Add("Dauer", 60);

            }
            else if (radioBtnDeparturePlan.Checked)
            {
                txtDestination.Enabled = false;
                btnSearchConnection.Text = "Abfahrt suchen";
                txtTime.Enabled = false;
                datePicker.Enabled = false;

                listViewConnections.Items.Clear();
                listViewConnections.Columns.Clear();
                listViewConnections.Columns.Add("Von", 100);
                listViewConnections.Columns.Add("Nach", 100);
                listViewConnections.Columns.Add("Zeit", 110);
                listViewConnections.Columns.Add("Zug/Bus Nr.", 100);
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

        private void btnShowOnMap_Click(object sender, EventArgs e)
        {
            ShowMap map = new ShowMap();
            map.Show();
        }

        private void listViewConnections_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuShowMap.Items.Clear();
            if (e.Button == MouseButtons.Right)
            {
                ToolStripMenuItem menuItemStart = new ToolStripMenuItem("Startort auf Karte anzeigen");
                ToolStripMenuItem menuItemEnd = new ToolStripMenuItem("Zielort auf Karte anzeigen");

                menuItemStart.Click += new EventHandler(menuItemStart_Click);
                menuItemEnd.Click += new EventHandler(menuItemEnd_Click);

                contextMenuShowMap.Items.AddRange(new ToolStripItem[]{ menuItemStart, menuItemEnd });

                contextMenuShowMap.Show(Cursor.Position);
            }
        }

        private void menuItemStart_Click(object sender, EventArgs e)
        {
            transport = new Transport();

            stations = transport.GetStations(listViewConnections.FocusedItem.Text);
            
            ShowMap map = new ShowMap();

            map.xCoordinate = stations.StationList.First().Coordinate.XCoordinate;
            map.yCoordinate = stations.StationList.First().Coordinate.YCoordinate;
            map.CityName = listViewConnections.FocusedItem.Text;

            map.Show();
        }

        private void menuItemEnd_Click(object sender, EventArgs e)
        {
            txtDeparture.Text = listViewConnections.SelectedItems[0].SubItems[1].Text;
        }
    }
}
