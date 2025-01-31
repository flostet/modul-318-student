﻿namespace ÖVFahrplan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrplan));
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewConnections = new System.Windows.Forms.ListView();
            this.listDestination = new System.Windows.Forms.ListBox();
            this.groupBoxSearchConnection = new System.Windows.Forms.GroupBox();
            this.listDeparture = new System.Windows.Forms.ListBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.radioBtnDeparturePlan = new System.Windows.Forms.RadioButton();
            this.radioBtnConnectionsPlan = new System.Windows.Forms.RadioButton();
            this.btnShowOnMap = new System.Windows.Forms.Button();
            this.contextMenuShowMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBoxSearchConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Location = new System.Drawing.Point(381, 127);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(122, 39);
            this.btnSearchConnection.TabIndex = 5;
            this.btnSearchConnection.Text = "Verbindung Suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(144, 89);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Uhrzeit:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(15, 89);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 13);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Datum:";
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
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(298, 25);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(36, 13);
            this.lblDestination.TabIndex = 5;
            this.lblDestination.Text = "Nach:";
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
            this.txtTime.Size = new System.Drawing.Size(59, 20);
            this.txtTime.TabIndex = 4;
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
            this.listViewConnections.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewConnections_MouseClick);
            // 
            // listDestination
            // 
            this.listDestination.FormattingEnabled = true;
            this.listDestination.Location = new System.Drawing.Point(301, 61);
            this.listDestination.Name = "listDestination";
            this.listDestination.Size = new System.Drawing.Size(202, 82);
            this.listDestination.TabIndex = 19;
            this.listDestination.Visible = false;
            this.listDestination.Click += new System.EventHandler(this.listDestination_Click);
            this.listDestination.DoubleClick += new System.EventHandler(this.listDestination_DoubleClick);
            this.listDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDestination_KeyDown);
            // 
            // groupBoxSearchConnection
            // 
            this.groupBoxSearchConnection.Controls.Add(this.listDeparture);
            this.groupBoxSearchConnection.Controls.Add(this.listDestination);
            this.groupBoxSearchConnection.Controls.Add(this.txtDestination);
            this.groupBoxSearchConnection.Controls.Add(this.txtDeparture);
            this.groupBoxSearchConnection.Controls.Add(this.radioBtnDeparturePlan);
            this.groupBoxSearchConnection.Controls.Add(this.radioBtnConnectionsPlan);
            this.groupBoxSearchConnection.Controls.Add(this.lblDestination);
            this.groupBoxSearchConnection.Controls.Add(this.lblTime);
            this.groupBoxSearchConnection.Controls.Add(this.lblDate);
            this.groupBoxSearchConnection.Controls.Add(this.label1);
            this.groupBoxSearchConnection.Controls.Add(this.datePicker);
            this.groupBoxSearchConnection.Controls.Add(this.btnSearchConnection);
            this.groupBoxSearchConnection.Controls.Add(this.txtTime);
            this.groupBoxSearchConnection.Location = new System.Drawing.Point(16, 6);
            this.groupBoxSearchConnection.Name = "groupBoxSearchConnection";
            this.groupBoxSearchConnection.Size = new System.Drawing.Size(509, 189);
            this.groupBoxSearchConnection.TabIndex = 0;
            this.groupBoxSearchConnection.TabStop = false;
            this.groupBoxSearchConnection.Text = "Verbindungen suchen";
            this.groupBoxSearchConnection.Click += new System.EventHandler(this.groupBoxSearchConnection_Click);
            // 
            // listDeparture
            // 
            this.listDeparture.FormattingEnabled = true;
            this.listDeparture.Location = new System.Drawing.Point(14, 61);
            this.listDeparture.Name = "listDeparture";
            this.listDeparture.Size = new System.Drawing.Size(203, 82);
            this.listDeparture.TabIndex = 18;
            this.listDeparture.Visible = false;
            this.listDeparture.Click += new System.EventHandler(this.listDeparture_Click);
            this.listDeparture.DoubleClick += new System.EventHandler(this.listDeparture_DoubleClick);
            this.listDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDeparture_KeyDown);
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(301, 42);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(202, 20);
            this.txtDestination.TabIndex = 1;
            this.txtDestination.Click += new System.EventHandler(this.txtDestination_Click);
            this.txtDestination.TextChanged += new System.EventHandler(this.txtDestination_TextChanged);
            this.txtDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDestination_KeyDown);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(14, 42);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(203, 20);
            this.txtDeparture.TabIndex = 0;
            this.txtDeparture.Click += new System.EventHandler(this.txtDeparture_Click);
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
            this.btnShowOnMap.Location = new System.Drawing.Point(16, 450);
            this.btnShowOnMap.Name = "btnShowOnMap";
            this.btnShowOnMap.Size = new System.Drawing.Size(114, 36);
            this.btnShowOnMap.TabIndex = 9;
            this.btnShowOnMap.Text = "Auf Karte suchen";
            this.btnShowOnMap.UseVisualStyleBackColor = true;
            this.btnShowOnMap.Click += new System.EventHandler(this.btnShowOnMap_Click);
            // 
            // contextMenuShowMap
            // 
            this.contextMenuShowMap.Name = "contextMenuShowMap";
            this.contextMenuShowMap.Size = new System.Drawing.Size(61, 4);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 496);
            this.Controls.Add(this.btnShowOnMap);
            this.Controls.Add(this.groupBoxSearchConnection);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fahrplan";
            this.Text = "ÖV-Fahrplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxSearchConnection.ResumeLayout(false);
            this.groupBoxSearchConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewConnections;
        private System.Windows.Forms.GroupBox groupBoxSearchConnection;
        private System.Windows.Forms.RadioButton radioBtnDeparturePlan;
        private System.Windows.Forms.RadioButton radioBtnConnectionsPlan;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.ListBox listDestination;
        private System.Windows.Forms.ListBox listDeparture;
        private System.Windows.Forms.Button btnShowOnMap;
        private System.Windows.Forms.ContextMenuStrip contextMenuShowMap;
    }
}

