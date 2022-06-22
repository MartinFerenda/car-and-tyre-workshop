namespace PI_Projekt_Autokuca
{
    partial class Proba
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
            this.txtZauzeto = new System.Windows.Forms.TextBox();
            this.txtSlobodno = new System.Windows.Forms.TextBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.Termin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblZauzeto = new System.Windows.Forms.Label();
            this.lblSlobodno = new System.Windows.Forms.Label();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.lblTermini = new System.Windows.Forms.Label();
            this.cmbSat = new System.Windows.Forms.ComboBox();
            this.lblSat = new System.Windows.Forms.Label();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.dgvMojeRezervacije = new System.Windows.Forms.DataGridView();
            this.lblMojeRezervacije = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.cmbPredmetRezervacije = new System.Windows.Forms.ComboBox();
            this.lblPredmetRezervacije = new System.Windows.Forms.Label();
            this.cmbVozilo = new System.Windows.Forms.ComboBox();
            this.lblOdabirVozila = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.mcOdabirDatuma = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // txtZauzeto
            // 
            this.txtZauzeto.BackColor = System.Drawing.Color.Red;
            this.txtZauzeto.Location = new System.Drawing.Point(488, 370);
            this.txtZauzeto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZauzeto.Multiline = true;
            this.txtZauzeto.Name = "txtZauzeto";
            this.txtZauzeto.Size = new System.Drawing.Size(49, 50);
            this.txtZauzeto.TabIndex = 41;
            // 
            // txtSlobodno
            // 
            this.txtSlobodno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtSlobodno.Location = new System.Drawing.Point(340, 370);
            this.txtSlobodno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlobodno.Multiline = true;
            this.txtSlobodno.Name = "txtSlobodno";
            this.txtSlobodno.Size = new System.Drawing.Size(49, 50);
            this.txtSlobodno.TabIndex = 40;
            // 
            // dgvTermini
            // 
            this.dgvTermini.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Termin,
            this.Status});
            this.dgvTermini.Location = new System.Drawing.Point(340, 30);
            this.dgvTermini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(408, 318);
            this.dgvTermini.TabIndex = 39;
            // 
            // Termin
            // 
            this.Termin.HeaderText = "Termin";
            this.Termin.MinimumWidth = 6;
            this.Termin.Name = "Termin";
            this.Termin.ReadOnly = true;
            this.Termin.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Slobodno/Zauzeto";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // lblZauzeto
            // 
            this.lblZauzeto.AutoSize = true;
            this.lblZauzeto.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZauzeto.Location = new System.Drawing.Point(544, 389);
            this.lblZauzeto.Name = "lblZauzeto";
            this.lblZauzeto.Size = new System.Drawing.Size(56, 18);
            this.lblZauzeto.TabIndex = 38;
            this.lblZauzeto.Text = "Zauzeto";
            // 
            // lblSlobodno
            // 
            this.lblSlobodno.AutoSize = true;
            this.lblSlobodno.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlobodno.Location = new System.Drawing.Point(396, 389);
            this.lblSlobodno.Name = "lblSlobodno";
            this.lblSlobodno.Size = new System.Drawing.Size(64, 18);
            this.lblSlobodno.TabIndex = 37;
            this.lblSlobodno.Text = "Slobodno";
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegenda.Location = new System.Drawing.Point(337, 350);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(64, 18);
            this.lblLegenda.TabIndex = 36;
            this.lblLegenda.Text = "Legenda:";
            // 
            // lblTermini
            // 
            this.lblTermini.AutoSize = true;
            this.lblTermini.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermini.Location = new System.Drawing.Point(337, 9);
            this.lblTermini.Name = "lblTermini";
            this.lblTermini.Size = new System.Drawing.Size(60, 18);
            this.lblTermini.TabIndex = 35;
            this.lblTermini.Text = "Termini:";
            // 
            // cmbSat
            // 
            this.cmbSat.FormattingEnabled = true;
            this.cmbSat.Location = new System.Drawing.Point(9, 452);
            this.cmbSat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSat.Name = "cmbSat";
            this.cmbSat.Size = new System.Drawing.Size(301, 24);
            this.cmbSat.TabIndex = 34;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(9, 431);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(32, 18);
            this.lblSat.TabIndex = 33;
            this.lblSat.Text = "Sat:";
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(9, 151);
            this.cmbLokacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(301, 24);
            this.cmbLokacija.TabIndex = 32;
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(9, 130);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(64, 18);
            this.lblLokacija.TabIndex = 31;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // dgvMojeRezervacije
            // 
            this.dgvMojeRezervacije.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMojeRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeRezervacije.Location = new System.Drawing.Point(781, 30);
            this.dgvMojeRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMojeRezervacije.Name = "dgvMojeRezervacije";
            this.dgvMojeRezervacije.RowHeadersWidth = 51;
            this.dgvMojeRezervacije.RowTemplate.Height = 24;
            this.dgvMojeRezervacije.Size = new System.Drawing.Size(464, 446);
            this.dgvMojeRezervacije.TabIndex = 30;
            // 
            // lblMojeRezervacije
            // 
            this.lblMojeRezervacije.AutoSize = true;
            this.lblMojeRezervacije.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojeRezervacije.Location = new System.Drawing.Point(779, 9);
            this.lblMojeRezervacije.Name = "lblMojeRezervacije";
            this.lblMojeRezervacije.Size = new System.Drawing.Size(116, 18);
            this.lblMojeRezervacije.TabIndex = 29;
            this.lblMojeRezervacije.Text = "Moje rezervacije:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(9, 190);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(52, 18);
            this.lblDatum.TabIndex = 28;
            this.lblDatum.Text = "Datum:";
            // 
            // cmbPredmetRezervacije
            // 
            this.cmbPredmetRezervacije.FormattingEnabled = true;
            this.cmbPredmetRezervacije.Location = new System.Drawing.Point(9, 89);
            this.cmbPredmetRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPredmetRezervacije.Name = "cmbPredmetRezervacije";
            this.cmbPredmetRezervacije.Size = new System.Drawing.Size(301, 24);
            this.cmbPredmetRezervacije.TabIndex = 27;
            // 
            // lblPredmetRezervacije
            // 
            this.lblPredmetRezervacije.AutoSize = true;
            this.lblPredmetRezervacije.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredmetRezervacije.Location = new System.Drawing.Point(9, 68);
            this.lblPredmetRezervacije.Name = "lblPredmetRezervacije";
            this.lblPredmetRezervacije.Size = new System.Drawing.Size(139, 18);
            this.lblPredmetRezervacije.TabIndex = 26;
            this.lblPredmetRezervacije.Text = "Predmet rezervacije:";
            // 
            // cmbVozilo
            // 
            this.cmbVozilo.FormattingEnabled = true;
            this.cmbVozilo.Location = new System.Drawing.Point(9, 30);
            this.cmbVozilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbVozilo.Name = "cmbVozilo";
            this.cmbVozilo.Size = new System.Drawing.Size(301, 24);
            this.cmbVozilo.TabIndex = 25;
            // 
            // lblOdabirVozila
            // 
            this.lblOdabirVozila.AutoSize = true;
            this.lblOdabirVozila.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabirVozila.Location = new System.Drawing.Point(9, 9);
            this.lblOdabirVozila.Name = "lblOdabirVozila";
            this.lblOdabirVozila.Size = new System.Drawing.Size(49, 18);
            this.lblOdabirVozila.TabIndex = 24;
            this.lblOdabirVozila.Text = "Vozilo:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(1140, 498);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 39);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezerviraj.Location = new System.Drawing.Point(9, 498);
            this.btnRezerviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(105, 39);
            this.btnRezerviraj.TabIndex = 22;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            // 
            // mcOdabirDatuma
            // 
            this.mcOdabirDatuma.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcOdabirDatuma.Location = new System.Drawing.Point(9, 215);
            this.mcOdabirDatuma.MaxSelectionCount = 1;
            this.mcOdabirDatuma.Name = "mcOdabirDatuma";
            this.mcOdabirDatuma.TabIndex = 21;
            // 
            // Proba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 550);
            this.Controls.Add(this.txtZauzeto);
            this.Controls.Add(this.txtSlobodno);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.lblZauzeto);
            this.Controls.Add(this.lblSlobodno);
            this.Controls.Add(this.lblLegenda);
            this.Controls.Add(this.lblTermini);
            this.Controls.Add(this.cmbSat);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proba";
            this.Text = "Proba";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZauzeto;
        private System.Windows.Forms.TextBox txtSlobodno;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label lblZauzeto;
        private System.Windows.Forms.Label lblSlobodno;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.Label lblTermini;
        private System.Windows.Forms.ComboBox cmbSat;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.DataGridView dgvMojeRezervacije;
        private System.Windows.Forms.Label lblMojeRezervacije;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ComboBox cmbPredmetRezervacije;
        private System.Windows.Forms.Label lblPredmetRezervacije;
        private System.Windows.Forms.ComboBox cmbVozilo;
        private System.Windows.Forms.Label lblOdabirVozila;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.MonthCalendar mcOdabirDatuma;
    }
}