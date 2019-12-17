namespace ÖVFahrplan
{
    partial class Fahrplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrplan));
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listDeparture = new System.Windows.Forms.ListBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.listDestination = new System.Windows.Forms.ListBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.radioBtnDeparturePlan = new System.Windows.Forms.RadioButton();
            this.radioBtnConnectionsPlan = new System.Windows.Forms.RadioButton();
            this.btnShowOnMap = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(278, 127);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(122, 39);
            this.btnSearchConnection.TabIndex = 5;
            this.btnSearchConnection.Text = "Verbindung Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Uhrzeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum:";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd:MM:yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(15, 109);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(92, 20);
            this.datePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Von:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(147, 109);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 4;
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(16, 450);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(115, 36);
            this.btnSendMail.TabIndex = 7;
            this.btnSendMail.Text = "per Mail versenden";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(432, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 36);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Beenden";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewConnections);
            this.groupBox2.Location = new System.Drawing.Point(16, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 234);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verbindungen";
            // 
            // listViewConnections
            // 
            this.listViewConnections.FullRowSelect = true;
            this.listViewConnections.GridLines = true;
            this.listViewConnections.HideSelection = false;
            this.listViewConnections.Location = new System.Drawing.Point(10, 19);
            this.listViewConnections.Name = "listViewConnections";
            this.listViewConnections.Size = new System.Drawing.Size(493, 202);
            this.listViewConnections.TabIndex = 7;
            this.listViewConnections.UseCompatibleStateImageBehavior = false;
            this.listViewConnections.View = System.Windows.Forms.View.Details;
            this.listViewConnections.DoubleClick += new System.EventHandler(this.listViewConnections_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listDeparture);
            this.groupBox1.Controls.Add(this.txtDestination);
            this.groupBox1.Controls.Add(this.listDestination);
            this.groupBox1.Controls.Add(this.txtDeparture);
            this.groupBox1.Controls.Add(this.radioBtnDeparturePlan);
            this.groupBox1.Controls.Add(this.radioBtnConnectionsPlan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.btnSearchConnection);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Location = new System.Drawing.Point(16, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eingaben";
            this.groupBox1.Click += new System.EventHandler(this.groupBox1_Click);
            // 
            // listDeparture
            // 
            this.listDeparture.FormattingEnabled = true;
            this.listDeparture.Location = new System.Drawing.Point(14, 61);
            this.listDeparture.Name = "listDeparture";
            this.listDeparture.Size = new System.Drawing.Size(172, 82);
            this.listDeparture.TabIndex = 18;
            this.listDeparture.Visible = false;
            this.listDeparture.Click += new System.EventHandler(this.listDeparture_Click);
            this.listDeparture.DoubleClick += new System.EventHandler(this.listDeparture_DoubleClick);
            this.listDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDeparture_KeyDown);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(228, 43);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(172, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            this.txtDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestination_KeyDown);
            // 
            // listDestination
            // 
            this.listDestination.FormattingEnabled = true;
            this.listDestination.Location = new System.Drawing.Point(228, 61);
            this.listDestination.Name = "listDestination";
            this.listDestination.Size = new System.Drawing.Size(172, 82);
            this.listDestination.TabIndex = 19;
            this.listDestination.Visible = false;
            this.listDestination.Click += new System.EventHandler(this.listDestination_Click);
            this.listDestination.DoubleClick += new System.EventHandler(this.listDestination_DoubleClick);
            this.listDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDestination_KeyDown);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(14, 42);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(172, 20);
            this.txtDeparture.TabIndex = 0;
            this.txtDeparture.TextChanged += new System.EventHandler(this.txtDeparture_TextChanged);
            this.txtDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeparture_KeyDown);
            // 
            // radioBtnDeparturePlan
            // 
            this.radioBtnDeparturePlan.AutoSize = true;
            this.radioBtnDeparturePlan.Location = new System.Drawing.Point(125, 149);
            this.radioBtnDeparturePlan.Name = "radioBtnDeparturePlan";
            this.radioBtnDeparturePlan.Size = new System.Drawing.Size(142, 17);
            this.radioBtnDeparturePlan.TabIndex = 15;
            this.radioBtnDeparturePlan.TabStop = true;
            this.radioBtnDeparturePlan.Text = "Verbindungen ab Station";
            this.radioBtnDeparturePlan.UseVisualStyleBackColor = true;
            // 
            // radioBtnConnectionsPlan
            // 
            this.radioBtnConnectionsPlan.AutoSize = true;
            this.radioBtnConnectionsPlan.Location = new System.Drawing.Point(15, 149);
            this.radioBtnConnectionsPlan.Name = "radioBtnConnectionsPlan";
            this.radioBtnConnectionsPlan.Size = new System.Drawing.Size(104, 17);
            this.radioBtnConnectionsPlan.TabIndex = 14;
            this.radioBtnConnectionsPlan.TabStop = true;
            this.radioBtnConnectionsPlan.Text = "Verbindungsplan";
            this.radioBtnConnectionsPlan.UseVisualStyleBackColor = true;
            this.radioBtnConnectionsPlan.CheckedChanged += new System.EventHandler(this.radioBtnConnectionsPlan_CheckedChanged);
            // 
            // btnShowOnMap
            // 
            this.btnShowOnMap.Location = new System.Drawing.Point(218, 450);
            this.btnShowOnMap.Name = "btnShowOnMap";
            this.btnShowOnMap.Size = new System.Drawing.Size(114, 36);
            this.btnShowOnMap.TabIndex = 9;
            this.btnShowOnMap.Text = "Auf Karte suchen";
            this.btnShowOnMap.UseVisualStyleBackColor = true;
            this.btnShowOnMap.Click += new System.EventHandler(this.btnShowOnMap_Click);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 496);
            this.Controls.Add(this.btnShowOnMap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fahrplan";
            this.Text = "ÖV-Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewConnections;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnDeparturePlan;
        private System.Windows.Forms.RadioButton radioBtnConnectionsPlan;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.ListBox listDestination;
        private System.Windows.Forms.ListBox listDeparture;
        private System.Windows.Forms.Button btnShowOnMap;
    }
}

