namespace ÖVFahrplan
{
    partial class ShowMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapControlStations = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnShowOnMap = new System.Windows.Forms.Button();
            this.listStations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mapControlStations
            // 
            this.mapControlStations.Bearing = 0F;
            this.mapControlStations.CanDragMap = true;
            this.mapControlStations.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapControlStations.GrayScaleMode = false;
            this.mapControlStations.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapControlStations.LevelsKeepInMemmory = 5;
            this.mapControlStations.Location = new System.Drawing.Point(-3, 52);
            this.mapControlStations.MarkersEnabled = true;
            this.mapControlStations.MaxZoom = 2;
            this.mapControlStations.MinZoom = 2;
            this.mapControlStations.MouseWheelZoomEnabled = true;
            this.mapControlStations.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapControlStations.Name = "mapControlStations";
            this.mapControlStations.NegativeMode = false;
            this.mapControlStations.PolygonsEnabled = true;
            this.mapControlStations.RetryLoadTile = 0;
            this.mapControlStations.RoutesEnabled = true;
            this.mapControlStations.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapControlStations.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapControlStations.ShowTileGridLines = false;
            this.mapControlStations.Size = new System.Drawing.Size(728, 452);
            this.mapControlStations.TabIndex = 0;
            this.mapControlStations.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Station: ";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(64, 13);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(197, 20);
            this.txtStation.TabIndex = 2;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            this.txtStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStation_KeyDown);
            // 
            // btnShowOnMap
            // 
            this.btnShowOnMap.Location = new System.Drawing.Point(559, 5);
            this.btnShowOnMap.Name = "btnShowOnMap";
            this.btnShowOnMap.Size = new System.Drawing.Size(148, 34);
            this.btnShowOnMap.TabIndex = 3;
            this.btnShowOnMap.Text = "auf Karte anzeigen";
            this.btnShowOnMap.UseVisualStyleBackColor = true;
            this.btnShowOnMap.Click += new System.EventHandler(this.btnShowOnMap_Click);
            // 
            // listStations
            // 
            this.listStations.FormattingEnabled = true;
            this.listStations.Location = new System.Drawing.Point(64, 29);
            this.listStations.Name = "listStations";
            this.listStations.Size = new System.Drawing.Size(197, 95);
            this.listStations.TabIndex = 4;
            this.listStations.Visible = false;
            this.listStations.Click += new System.EventHandler(this.listStations_Click);
            this.listStations.DoubleClick += new System.EventHandler(this.listStations_DoubleClick);
            this.listStations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listStations_KeyDown);
            // 
            // ShowMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 498);
            this.Controls.Add(this.listStations);
            this.Controls.Add(this.btnShowOnMap);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapControlStations);
            this.Name = "ShowMap";
            this.Text = "ShowMap";
            this.Load += new System.EventHandler(this.ShowMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControlStations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button btnShowOnMap;
        private System.Windows.Forms.ListBox listStations;
    }
}