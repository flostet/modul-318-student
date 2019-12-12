namespace ÖVFahrplan
{
    partial class Details
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStartort = new System.Windows.Forms.Label();
            this.lblZielort = new System.Windows.Forms.Label();
            this.lblGleisVon = new System.Windows.Forms.Label();
            this.lblDetailsVon = new System.Windows.Forms.Label();
            this.lblGleisNach = new System.Windows.Forms.Label();
            this.lblDetialsNach = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetialsNach);
            this.groupBox1.Controls.Add(this.lblGleisNach);
            this.groupBox1.Controls.Add(this.lblDetailsVon);
            this.groupBox1.Controls.Add(this.lblGleisVon);
            this.groupBox1.Controls.Add(this.lblZielort);
            this.groupBox1.Controls.Add(this.lblStartort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindungsdetails";
            // 
            // lblStartort
            // 
            this.lblStartort.AutoSize = true;
            this.lblStartort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartort.Location = new System.Drawing.Point(6, 26);
            this.lblStartort.Name = "lblStartort";
            this.lblStartort.Size = new System.Drawing.Size(57, 13);
            this.lblStartort.TabIndex = 0;
            this.lblStartort.Text = "Von XXX";
            // 
            // lblZielort
            // 
            this.lblZielort.AutoSize = true;
            this.lblZielort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZielort.Location = new System.Drawing.Point(9, 103);
            this.lblZielort.Name = "lblZielort";
            this.lblZielort.Size = new System.Drawing.Size(65, 13);
            this.lblZielort.TabIndex = 1;
            this.lblZielort.Text = "Nach XXX";
            // 
            // lblGleisVon
            // 
            this.lblGleisVon.AutoSize = true;
            this.lblGleisVon.Location = new System.Drawing.Point(9, 50);
            this.lblGleisVon.Name = "lblGleisVon";
            this.lblGleisVon.Size = new System.Drawing.Size(35, 13);
            this.lblGleisVon.TabIndex = 2;
            this.lblGleisVon.Text = "label1";
            // 
            // lblDetailsVon
            // 
            this.lblDetailsVon.AutoSize = true;
            this.lblDetailsVon.Location = new System.Drawing.Point(12, 67);
            this.lblDetailsVon.Name = "lblDetailsVon";
            this.lblDetailsVon.Size = new System.Drawing.Size(35, 13);
            this.lblDetailsVon.TabIndex = 3;
            this.lblDetailsVon.Text = "label2";
            // 
            // lblGleisNach
            // 
            this.lblGleisNach.AutoSize = true;
            this.lblGleisNach.Location = new System.Drawing.Point(15, 126);
            this.lblGleisNach.Name = "lblGleisNach";
            this.lblGleisNach.Size = new System.Drawing.Size(35, 13);
            this.lblGleisNach.TabIndex = 4;
            this.lblGleisNach.Text = "label1";
            // 
            // lblDetialsNach
            // 
            this.lblDetialsNach.AutoSize = true;
            this.lblDetialsNach.Location = new System.Drawing.Point(15, 149);
            this.lblDetialsNach.Name = "lblDetialsNach";
            this.lblDetialsNach.Size = new System.Drawing.Size(35, 13);
            this.lblDetialsNach.TabIndex = 5;
            this.lblDetialsNach.Text = "label2";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Details";
            this.Text = "ÖV-Fahrplan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGleisVon;
        private System.Windows.Forms.Label lblZielort;
        private System.Windows.Forms.Label lblStartort;
        private System.Windows.Forms.Label lblDetailsVon;
        private System.Windows.Forms.Label lblDetialsNach;
        private System.Windows.Forms.Label lblGleisNach;
    }
}