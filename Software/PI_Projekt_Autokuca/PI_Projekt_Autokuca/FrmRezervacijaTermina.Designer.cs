namespace PI_Projekt_Autokuca
{
    partial class FrmRezervacijaTermina
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
            this.mcOdabirDatuma = new System.Windows.Forms.MonthCalendar();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblOdabirVozila = new System.Windows.Forms.Label();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.lblPredmetRezervacije = new System.Windows.Forms.Label();
            this.cmbPredmetRezervacije = new System.Windows.Forms.ComboBox();
            this.lblMojeRezervacije = new System.Windows.Forms.Label();
            this.dgvMojeRezervacije = new System.Windows.Forms.DataGridView();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.lblSat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // mcOdabirDatuma
            // 
            this.mcOdabirDatuma.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcOdabirDatuma.Location = new System.Drawing.Point(12, 219);
            this.mcOdabirDatuma.Name = "mcOdabirDatuma";
            this.mcOdabirDatuma.TabIndex = 0;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.Location = new System.Drawing.Point(12, 502);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(105, 40);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(677, 502);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 40);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // lblOdabirVozila
            // 
            this.lblOdabirVozila.AutoSize = true;
            this.lblOdabirVozila.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabirVozila.Location = new System.Drawing.Point(12, 13);
            this.lblOdabirVozila.Name = "lblOdabirVozila";
            this.lblOdabirVozila.Size = new System.Drawing.Size(49, 18);
            this.lblOdabirVozila.TabIndex = 3;
            this.lblOdabirVozila.Text = "Vozilo:";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(12, 34);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(262, 24);
            this.cmbVozilo.TabIndex = 4;
            // 
            // lblPredmetRezervacije
            // 
            this.lblPredmetRezervacije.AutoSize = true;
            this.lblPredmetRezervacije.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetRezervacije.Location = new System.Drawing.Point(12, 72);
            this.lblPredmetRezervacije.Name = "lblPredmetRezervacije";
            this.lblPredmetRezervacije.Size = new System.Drawing.Size(139, 18);
            this.lblPredmetRezervacije.TabIndex = 5;
            this.lblPredmetRezervacije.Text = "Predmet rezervacije:";
            // 
            // cmbPredmetRezervacije
            // 
            this.cmbPredmetRezervacije.FormattingEnabled = true;
            this.cmbPredmetRezervacije.Location = new System.Drawing.Point(12, 93);
            this.cmbPredmetRezervacije.Name = "cmbPredmetRezervacije";
            this.cmbPredmetRezervacije.Size = new System.Drawing.Size(262, 24);
            this.cmbPredmetRezervacije.TabIndex = 6;
            // 
            // lblMojeRezervacije
            // 
            this.lblMojeRezervacije.AutoSize = true;
            this.lblMojeRezervacije.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojeRezervacije.Location = new System.Drawing.Point(315, 13);
            this.lblMojeRezervacije.Name = "lblMojeRezervacije";
            this.lblMojeRezervacije.Size = new System.Drawing.Size(116, 18);
            this.lblMojeRezervacije.TabIndex = 8;
            this.lblMojeRezervacije.Text = "Moje rezervacije:";
            // 
            // dgvMojeRezervacije
            // 
            this.dgvMojeRezervacije.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMojeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeRezervacije.Location = new System.Drawing.Point(318, 34);
            this.dgvMojeRezervacije.Name = "dgvMojeRezervacije";
            this.dgvMojeRezervacije.RowHeadersWidth = 51;
            this.dgvMojeRezervacije.RowTemplate.Height = 24;
            this.dgvMojeRezervacije.Size = new System.Drawing.Size(464, 446);
            this.dgvMojeRezervacije.TabIndex = 9;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(12, 194);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(52, 18);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(12, 134);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(64, 18);
            this.lblLokacija.TabIndex = 10;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(12, 155);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(262, 24);
            this.cmbLokacija.TabIndex = 11;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(12, 435);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(32, 18);
            this.lblSat.TabIndex = 12;
            this.lblSat.Text = "Sat:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 456);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // FrmRezervacijaTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1086, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.dgvMojeRezervacije);
            this.Controls.Add(this.lblMojeRezervacije);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.cmbPredmetRezervacije);
            this.Controls.Add(this.lblPredmetRezervacije);
            this.Controls.Add(this.cmbVozilo);
            this.Controls.Add(this.lblOdabirVozila);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.mcOdabirDatuma);
            this.Name = "FrmRezervacijaTermina";
            this.Text = "Rezervacija termina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcOdabirDatuma;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblOdabirVozila;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label lblPredmetRezervacije;
        private System.Windows.Forms.ComboBox cmbPredmetRezervacije;
        private System.Windows.Forms.Label lblMojeRezervacije;
        private System.Windows.Forms.DataGridView dgvMojeRezervacije;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}