namespace PI_Projekt_Autokuca
{
    partial class FrmPrikazLokacijaServisa
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
            this.dgvLokacije = new System.Windows.Forms.DataGridView();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.btnNovaLokacija = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.lblPodaci = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.AllowUserToAddRows = false;
            this.dgvLokacije.AllowUserToDeleteRows = false;
            this.dgvLokacije.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Location = new System.Drawing.Point(14, 73);
            this.dgvLokacije.MultiSelect = false;
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.RowHeadersWidth = 51;
            this.dgvLokacije.RowTemplate.Height = 24;
            this.dgvLokacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokacije.Size = new System.Drawing.Size(1026, 311);
            this.dgvLokacije.TabIndex = 0;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(933, 399);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 42);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Zatvori";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(820, 399);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(107, 42);
            this.btnRezerviraj.TabIndex = 2;
            this.btnRezerviraj.Text = "Rezerviraj termin";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // btnNovaLokacija
            // 
            this.btnNovaLokacija.Location = new System.Drawing.Point(14, 399);
            this.btnNovaLokacija.Name = "btnNovaLokacija";
            this.btnNovaLokacija.Size = new System.Drawing.Size(107, 42);
            this.btnNovaLokacija.TabIndex = 3;
            this.btnNovaLokacija.Text = "Dodaj novu lokaciju";
            this.btnNovaLokacija.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(127, 399);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(107, 42);
            this.btnAzuriraj.TabIndex = 4;
            this.btnAzuriraj.Text = "Ažuriraj lokaciju";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(240, 399);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(107, 42);
            this.btnIzbrisi.TabIndex = 5;
            this.btnIzbrisi.Text = "Izbriši lokaciju";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.Location = new System.Drawing.Point(12, 9);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(287, 18);
            this.lblPretraga.TabIndex = 6;
            this.lblPretraga.Text = "Upišite naziv podružnice koju želite pronaći:";
            // 
            // lblPodaci
            // 
            this.lblPodaci.AutoSize = true;
            this.lblPodaci.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodaci.Location = new System.Drawing.Point(12, 52);
            this.lblPodaci.Name = "lblPodaci";
            this.lblPodaci.Size = new System.Drawing.Size(156, 18);
            this.lblPodaci.TabIndex = 7;
            this.lblPodaci.Text = "Podaci o podružnicama:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(345, 7);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(189, 22);
            this.txtPretraga.TabIndex = 8;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // FrmPrikazLokacijaServisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1052, 454);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPodaci);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnNovaLokacija);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvLokacije);
            this.Name = "FrmPrikazLokacijaServisa";
            this.Text = "Prikaz lokacija servisa";
            this.Load += new System.EventHandler(this.FrmPrikazLokacijaServisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.Button btnNovaLokacija;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.Label lblPodaci;
        private System.Windows.Forms.TextBox txtPretraga;
    }
}