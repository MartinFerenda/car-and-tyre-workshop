namespace PI_Projekt_Autokuca
{
    partial class FrmGlavniIzbornik
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
            this.btnPrikazLokacijaServisa = new System.Windows.Forms.Button();
            this.btnRezervacijaTermina = new System.Windows.Forms.Button();
            this.btnSkladisteIEvidencija = new System.Windows.Forms.Button();
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikazLokacijaServisa
            // 
            this.btnPrikazLokacijaServisa.Location = new System.Drawing.Point(44, 125);
            this.btnPrikazLokacijaServisa.Name = "btnPrikazLokacijaServisa";
            this.btnPrikazLokacijaServisa.Size = new System.Drawing.Size(177, 49);
            this.btnPrikazLokacijaServisa.TabIndex = 0;
            this.btnPrikazLokacijaServisa.Text = "Prikaz lokacija servisa";
            this.btnPrikazLokacijaServisa.UseVisualStyleBackColor = true;
            // 
            // btnRezervacijaTermina
            // 
            this.btnRezervacijaTermina.Location = new System.Drawing.Point(227, 125);
            this.btnRezervacijaTermina.Name = "btnRezervacijaTermina";
            this.btnRezervacijaTermina.Size = new System.Drawing.Size(177, 49);
            this.btnRezervacijaTermina.TabIndex = 1;
            this.btnRezervacijaTermina.Text = "Rezervacija termina";
            this.btnRezervacijaTermina.UseVisualStyleBackColor = true;
            // 
            // btnSkladisteIEvidencija
            // 
            this.btnSkladisteIEvidencija.Location = new System.Drawing.Point(410, 125);
            this.btnSkladisteIEvidencija.Name = "btnSkladisteIEvidencija";
            this.btnSkladisteIEvidencija.Size = new System.Drawing.Size(177, 49);
            this.btnSkladisteIEvidencija.TabIndex = 2;
            this.btnSkladisteIEvidencija.Text = "Skladište i evidencija";
            this.btnSkladisteIEvidencija.UseVisualStyleBackColor = true;
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobrodosli.Location = new System.Drawing.Point(339, 38);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(154, 31);
            this.lblDobrodosli.TabIndex = 3;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(651, 378);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(108, 42);
            this.btnOdjava.TabIndex = 4;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblDobrodosli);
            this.Controls.Add(this.btnSkladisteIEvidencija);
            this.Controls.Add(this.btnRezervacijaTermina);
            this.Controls.Add(this.btnPrikazLokacijaServisa);
            this.Name = "FrmGlavniIzbornik";
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazLokacijaServisa;
        private System.Windows.Forms.Button btnRezervacijaTermina;
        private System.Windows.Forms.Button btnSkladisteIEvidencija;
        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.Button btnOdjava;
    }
}

