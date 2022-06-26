namespace PI_Projekt_Autokuca
{
    partial class FrmIzborRezervacije
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnRezervirajProbnuVoznju = new System.Windows.Forms.Button();
            this.btnRezervirajServis = new System.Windows.Forms.Button();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(129, 219);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(105, 39);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnRezervirajProbnuVoznju
            // 
            this.btnRezervirajProbnuVoznju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervirajProbnuVoznju.Location = new System.Drawing.Point(15, 142);
            this.btnRezervirajProbnuVoznju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervirajProbnuVoznju.Name = "btnRezervirajProbnuVoznju";
            this.btnRezervirajProbnuVoznju.Size = new System.Drawing.Size(219, 49);
            this.btnRezervirajProbnuVoznju.TabIndex = 24;
            this.btnRezervirajProbnuVoznju.Text = "Rezerviraj termin probne vožnje";
            this.btnRezervirajProbnuVoznju.UseVisualStyleBackColor = true;
            this.btnRezervirajProbnuVoznju.Click += new System.EventHandler(this.btnRezervirajProbnuVoznju_Click);
            // 
            // btnRezervirajServis
            // 
            this.btnRezervirajServis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervirajServis.Location = new System.Drawing.Point(15, 71);
            this.btnRezervirajServis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervirajServis.Name = "btnRezervirajServis";
            this.btnRezervirajServis.Size = new System.Drawing.Size(219, 49);
            this.btnRezervirajServis.TabIndex = 25;
            this.btnRezervirajServis.Text = "Rezerviraj termin servisa";
            this.btnRezervirajServis.UseVisualStyleBackColor = true;
            this.btnRezervirajServis.Click += new System.EventHandler(this.btnRezervirajServis_Click);
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdabir.Location = new System.Drawing.Point(12, 40);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(184, 18);
            this.lblOdabir.TabIndex = 26;
            this.lblOdabir.Text = "Odaberite vrstu rezervacije:";
            // 
            // FrmIzborRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(246, 269);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.btnRezervirajServis);
            this.Controls.Add(this.btnRezervirajProbnuVoznju);
            this.Controls.Add(this.btnOdustani);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmIzborRezervacije";
            this.Text = "Izbor vrste rezervacije";
            this.Load += new System.EventHandler(this.Proba_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmIzborRezervacije_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnRezervirajProbnuVoznju;
        private System.Windows.Forms.Button btnRezervirajServis;
        private System.Windows.Forms.Label lblOdabir;
    }
}