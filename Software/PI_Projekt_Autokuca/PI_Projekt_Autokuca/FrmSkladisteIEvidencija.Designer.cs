namespace PI_Projekt_Autokuca
{
    partial class FrmSkladisteIEvidencija
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
            this.lblPrikazGuma = new System.Windows.Forms.Label();
            this.lblAutoDijelovi = new System.Windows.Forms.Label();
            this.dgvGume = new System.Windows.Forms.DataGridView();
            this.dgvDijelovi = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnDodajGumu = new System.Windows.Forms.Button();
            this.btnAzurirajGumu = new System.Windows.Forms.Button();
            this.btnIzbrisiGumu = new System.Windows.Forms.Button();
            this.btnDodajDio = new System.Windows.Forms.Button();
            this.btnIzbrisiDio = new System.Windows.Forms.Button();
            this.btnAzurirajDio = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretragaGuma = new System.Windows.Forms.TextBox();
            this.lblPretragaDio = new System.Windows.Forms.Label();
            this.txtPretragaNaziv = new System.Windows.Forms.TextBox();
            this.txtPromjenaKolicineGuma = new System.Windows.Forms.TextBox();
            this.txtPromjenaKolicineDio = new System.Windows.Forms.TextBox();
            this.btnDodajKolGuma = new System.Windows.Forms.Button();
            this.btnDodajKolDio = new System.Windows.Forms.Button();
            this.btnOduzmiKolGuma = new System.Windows.Forms.Button();
            this.btnOduzmiKolDio = new System.Windows.Forms.Button();
            this.gboxGumaKol = new System.Windows.Forms.GroupBox();
            this.gboxDioKol = new System.Windows.Forms.GroupBox();
            this.lblSkladiste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            this.gboxGumaKol.SuspendLayout();
            this.gboxDioKol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrikazGuma
            // 
            this.lblPrikazGuma.AutoSize = true;
            this.lblPrikazGuma.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrikazGuma.Location = new System.Drawing.Point(17, 96);
            this.lblPrikazGuma.Name = "lblPrikazGuma";
            this.lblPrikazGuma.Size = new System.Drawing.Size(89, 18);
            this.lblPrikazGuma.TabIndex = 0;
            this.lblPrikazGuma.Text = "Prikaz guma:";
            // 
            // lblAutoDijelovi
            // 
            this.lblAutoDijelovi.AutoSize = true;
            this.lblAutoDijelovi.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoDijelovi.Location = new System.Drawing.Point(703, 96);
            this.lblAutoDijelovi.Name = "lblAutoDijelovi";
            this.lblAutoDijelovi.Size = new System.Drawing.Size(195, 18);
            this.lblAutoDijelovi.TabIndex = 1;
            this.lblAutoDijelovi.Text = "Prikaz automobilskih dijelova:";
            // 
            // dgvGume
            // 
            this.dgvGume.AllowUserToAddRows = false;
            this.dgvGume.AllowUserToDeleteRows = false;
            this.dgvGume.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGume.Location = new System.Drawing.Point(18, 129);
            this.dgvGume.MultiSelect = false;
            this.dgvGume.Name = "dgvGume";
            this.dgvGume.ReadOnly = true;
            this.dgvGume.RowHeadersWidth = 51;
            this.dgvGume.RowTemplate.Height = 24;
            this.dgvGume.Size = new System.Drawing.Size(666, 321);
            this.dgvGume.TabIndex = 2;
            // 
            // dgvDijelovi
            // 
            this.dgvDijelovi.AllowUserToAddRows = false;
            this.dgvDijelovi.AllowUserToDeleteRows = false;
            this.dgvDijelovi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijelovi.Location = new System.Drawing.Point(706, 129);
            this.dgvDijelovi.MultiSelect = false;
            this.dgvDijelovi.Name = "dgvDijelovi";
            this.dgvDijelovi.ReadOnly = true;
            this.dgvDijelovi.RowHeadersWidth = 51;
            this.dgvDijelovi.RowTemplate.Height = 24;
            this.dgvDijelovi.Size = new System.Drawing.Size(618, 321);
            this.dgvDijelovi.TabIndex = 3;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(1217, 593);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(107, 42);
            this.btnZatvori.TabIndex = 4;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnDodajGumu
            // 
            this.btnDodajGumu.Location = new System.Drawing.Point(18, 536);
            this.btnDodajGumu.Name = "btnDodajGumu";
            this.btnDodajGumu.Size = new System.Drawing.Size(107, 62);
            this.btnDodajGumu.TabIndex = 5;
            this.btnDodajGumu.Text = "Dodaj novu gumu";
            this.btnDodajGumu.UseVisualStyleBackColor = true;
            this.btnDodajGumu.Click += new System.EventHandler(this.btnDodajGumu_Click);
            // 
            // btnAzurirajGumu
            // 
            this.btnAzurirajGumu.Location = new System.Drawing.Point(131, 536);
            this.btnAzurirajGumu.Name = "btnAzurirajGumu";
            this.btnAzurirajGumu.Size = new System.Drawing.Size(107, 62);
            this.btnAzurirajGumu.TabIndex = 6;
            this.btnAzurirajGumu.Text = "Ažuriraj postojeću gumu";
            this.btnAzurirajGumu.UseVisualStyleBackColor = true;
            this.btnAzurirajGumu.Click += new System.EventHandler(this.btnAzurirajGumu_Click);
            // 
            // btnIzbrisiGumu
            // 
            this.btnIzbrisiGumu.Location = new System.Drawing.Point(244, 536);
            this.btnIzbrisiGumu.Name = "btnIzbrisiGumu";
            this.btnIzbrisiGumu.Size = new System.Drawing.Size(107, 62);
            this.btnIzbrisiGumu.TabIndex = 7;
            this.btnIzbrisiGumu.Text = "Izbriši gumu";
            this.btnIzbrisiGumu.UseVisualStyleBackColor = true;
            this.btnIzbrisiGumu.Click += new System.EventHandler(this.btnIzbrisiGumu_Click);
            // 
            // btnDodajDio
            // 
            this.btnDodajDio.Location = new System.Drawing.Point(706, 536);
            this.btnDodajDio.Name = "btnDodajDio";
            this.btnDodajDio.Size = new System.Drawing.Size(107, 62);
            this.btnDodajDio.TabIndex = 8;
            this.btnDodajDio.Text = "Dodaj novi automobilski dio";
            this.btnDodajDio.UseVisualStyleBackColor = true;
            this.btnDodajDio.Click += new System.EventHandler(this.btnDodajDio_Click);
            // 
            // btnIzbrisiDio
            // 
            this.btnIzbrisiDio.Location = new System.Drawing.Point(932, 536);
            this.btnIzbrisiDio.Name = "btnIzbrisiDio";
            this.btnIzbrisiDio.Size = new System.Drawing.Size(107, 62);
            this.btnIzbrisiDio.TabIndex = 9;
            this.btnIzbrisiDio.Text = "Izbriši dio";
            this.btnIzbrisiDio.UseVisualStyleBackColor = true;
            this.btnIzbrisiDio.Click += new System.EventHandler(this.btnIzbrisiDio_Click);
            // 
            // btnAzurirajDio
            // 
            this.btnAzurirajDio.Location = new System.Drawing.Point(819, 536);
            this.btnAzurirajDio.Name = "btnAzurirajDio";
            this.btnAzurirajDio.Size = new System.Drawing.Size(107, 62);
            this.btnAzurirajDio.TabIndex = 10;
            this.btnAzurirajDio.Text = "Ažuriraj postojeći dio";
            this.btnAzurirajDio.UseVisualStyleBackColor = true;
            this.btnAzurirajDio.Click += new System.EventHandler(this.btnAzurirajDio_Click);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(406, 96);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(114, 18);
            this.lblPretraga.TabIndex = 11;
            this.lblPretraga.Text = "Pretraga po šifri:";
            // 
            // txtPretragaGuma
            // 
            this.txtPretragaGuma.Location = new System.Drawing.Point(537, 94);
            this.txtPretragaGuma.Name = "txtPretragaGuma";
            this.txtPretragaGuma.Size = new System.Drawing.Size(147, 22);
            this.txtPretragaGuma.TabIndex = 12;
            this.txtPretragaGuma.TextChanged += new System.EventHandler(this.txtPretragaGuma_TextChanged);
            // 
            // lblPretragaDio
            // 
            this.lblPretragaDio.AutoSize = true;
            this.lblPretragaDio.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretragaDio.Location = new System.Drawing.Point(1016, 96);
            this.lblPretragaDio.Name = "lblPretragaDio";
            this.lblPretragaDio.Size = new System.Drawing.Size(130, 18);
            this.lblPretragaDio.TabIndex = 13;
            this.lblPretragaDio.Text = "Pretraga po nazivu:";
            // 
            // txtPretragaNaziv
            // 
            this.txtPretragaNaziv.Location = new System.Drawing.Point(1177, 94);
            this.txtPretragaNaziv.Name = "txtPretragaNaziv";
            this.txtPretragaNaziv.Size = new System.Drawing.Size(147, 22);
            this.txtPretragaNaziv.TabIndex = 14;
            this.txtPretragaNaziv.TextChanged += new System.EventHandler(this.txtPretragaNaziv_TextChanged);
            // 
            // txtPromjenaKolicineGuma
            // 
            this.txtPromjenaKolicineGuma.Location = new System.Drawing.Point(12, 27);
            this.txtPromjenaKolicineGuma.Name = "txtPromjenaKolicineGuma";
            this.txtPromjenaKolicineGuma.Size = new System.Drawing.Size(147, 22);
            this.txtPromjenaKolicineGuma.TabIndex = 17;
            // 
            // txtPromjenaKolicineDio
            // 
            this.txtPromjenaKolicineDio.Location = new System.Drawing.Point(16, 27);
            this.txtPromjenaKolicineDio.Name = "txtPromjenaKolicineDio";
            this.txtPromjenaKolicineDio.Size = new System.Drawing.Size(147, 22);
            this.txtPromjenaKolicineDio.TabIndex = 18;
            // 
            // btnDodajKolGuma
            // 
            this.btnDodajKolGuma.Location = new System.Drawing.Point(165, 21);
            this.btnDodajKolGuma.Name = "btnDodajKolGuma";
            this.btnDodajKolGuma.Size = new System.Drawing.Size(107, 34);
            this.btnDodajKolGuma.TabIndex = 19;
            this.btnDodajKolGuma.Text = "Dodaj";
            this.btnDodajKolGuma.UseVisualStyleBackColor = true;
            this.btnDodajKolGuma.Click += new System.EventHandler(this.btnDodajKolGuma_Click);
            // 
            // btnDodajKolDio
            // 
            this.btnDodajKolDio.Location = new System.Drawing.Point(169, 21);
            this.btnDodajKolDio.Name = "btnDodajKolDio";
            this.btnDodajKolDio.Size = new System.Drawing.Size(107, 34);
            this.btnDodajKolDio.TabIndex = 20;
            this.btnDodajKolDio.Text = "Dodaj";
            this.btnDodajKolDio.UseVisualStyleBackColor = true;
            this.btnDodajKolDio.Click += new System.EventHandler(this.btnDodajKolDio_Click);
            // 
            // btnOduzmiKolGuma
            // 
            this.btnOduzmiKolGuma.Location = new System.Drawing.Point(278, 21);
            this.btnOduzmiKolGuma.Name = "btnOduzmiKolGuma";
            this.btnOduzmiKolGuma.Size = new System.Drawing.Size(107, 34);
            this.btnOduzmiKolGuma.TabIndex = 21;
            this.btnOduzmiKolGuma.Text = "Oduzmi";
            this.btnOduzmiKolGuma.UseVisualStyleBackColor = true;
            this.btnOduzmiKolGuma.Click += new System.EventHandler(this.btnOduzmiKolGuma_Click);
            // 
            // btnOduzmiKolDio
            // 
            this.btnOduzmiKolDio.Location = new System.Drawing.Point(281, 21);
            this.btnOduzmiKolDio.Name = "btnOduzmiKolDio";
            this.btnOduzmiKolDio.Size = new System.Drawing.Size(107, 34);
            this.btnOduzmiKolDio.TabIndex = 22;
            this.btnOduzmiKolDio.Text = "Oduzmi";
            this.btnOduzmiKolDio.UseVisualStyleBackColor = true;
            this.btnOduzmiKolDio.Click += new System.EventHandler(this.btnOduzmiKolDio_Click);
            // 
            // gboxGumaKol
            // 
            this.gboxGumaKol.Controls.Add(this.btnDodajKolGuma);
            this.gboxGumaKol.Controls.Add(this.txtPromjenaKolicineGuma);
            this.gboxGumaKol.Controls.Add(this.btnOduzmiKolGuma);
            this.gboxGumaKol.Location = new System.Drawing.Point(17, 456);
            this.gboxGumaKol.Name = "gboxGumaKol";
            this.gboxGumaKol.Size = new System.Drawing.Size(396, 66);
            this.gboxGumaKol.TabIndex = 23;
            this.gboxGumaKol.TabStop = false;
            this.gboxGumaKol.Text = "Količina:";
            // 
            // gboxDioKol
            // 
            this.gboxDioKol.Controls.Add(this.txtPromjenaKolicineDio);
            this.gboxDioKol.Controls.Add(this.btnDodajKolDio);
            this.gboxDioKol.Controls.Add(this.btnOduzmiKolDio);
            this.gboxDioKol.Location = new System.Drawing.Point(706, 456);
            this.gboxDioKol.Name = "gboxDioKol";
            this.gboxDioKol.Size = new System.Drawing.Size(402, 66);
            this.gboxDioKol.TabIndex = 24;
            this.gboxDioKol.TabStop = false;
            this.gboxDioKol.Text = "Količina:";
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkladiste.Location = new System.Drawing.Point(511, 28);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(130, 36);
            this.lblSkladiste.TabIndex = 25;
            this.lblSkladiste.Text = "Skladište";
            // 
            // FrmSkladisteIEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1345, 648);
            this.Controls.Add(this.lblSkladiste);
            this.Controls.Add(this.gboxDioKol);
            this.Controls.Add(this.gboxGumaKol);
            this.Controls.Add(this.txtPretragaNaziv);
            this.Controls.Add(this.lblPretragaDio);
            this.Controls.Add(this.txtPretragaGuma);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnAzurirajDio);
            this.Controls.Add(this.btnIzbrisiDio);
            this.Controls.Add(this.btnDodajDio);
            this.Controls.Add(this.btnIzbrisiGumu);
            this.Controls.Add(this.btnAzurirajGumu);
            this.Controls.Add(this.btnDodajGumu);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvDijelovi);
            this.Controls.Add(this.dgvGume);
            this.Controls.Add(this.lblAutoDijelovi);
            this.Controls.Add(this.lblPrikazGuma);
            this.Name = "FrmSkladisteIEvidencija";
            this.Text = "Skladište i evidencija";
            this.Load += new System.EventHandler(this.FrmSkladisteIEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            this.gboxGumaKol.ResumeLayout(false);
            this.gboxGumaKol.PerformLayout();
            this.gboxDioKol.ResumeLayout(false);
            this.gboxDioKol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrikazGuma;
        private System.Windows.Forms.Label lblAutoDijelovi;
        private System.Windows.Forms.DataGridView dgvGume;
        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnDodajGumu;
        private System.Windows.Forms.Button btnAzurirajGumu;
        private System.Windows.Forms.Button btnIzbrisiGumu;
        private System.Windows.Forms.Button btnDodajDio;
        private System.Windows.Forms.Button btnIzbrisiDio;
        private System.Windows.Forms.Button btnAzurirajDio;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretragaGuma;
        private System.Windows.Forms.Label lblPretragaDio;
        private System.Windows.Forms.TextBox txtPretragaNaziv;
        private System.Windows.Forms.TextBox txtPromjenaKolicineGuma;
        private System.Windows.Forms.TextBox txtPromjenaKolicineDio;
        private System.Windows.Forms.Button btnDodajKolGuma;
        private System.Windows.Forms.Button btnDodajKolDio;
        private System.Windows.Forms.Button btnOduzmiKolGuma;
        private System.Windows.Forms.Button btnOduzmiKolDio;
        private System.Windows.Forms.GroupBox gboxGumaKol;
        private System.Windows.Forms.GroupBox gboxDioKol;
        private System.Windows.Forms.Label lblSkladiste;
    }
}