namespace PI_Projekt_Autokuca
{
    partial class FrmMojeGume
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
            this.dgvMojeGume = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeGume)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMojeGume
            // 
            this.dgvMojeGume.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMojeGume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeGume.Location = new System.Drawing.Point(13, 13);
            this.dgvMojeGume.Name = "dgvMojeGume";
            this.dgvMojeGume.RowHeadersWidth = 51;
            this.dgvMojeGume.RowTemplate.Height = 24;
            this.dgvMojeGume.Size = new System.Drawing.Size(568, 294);
            this.dgvMojeGume.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(474, 324);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(107, 42);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FrmMojeGume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(596, 383);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvMojeGume);
            this.Name = "FrmMojeGume";
            this.Text = "Moje gume u skladištu";
            this.Load += new System.EventHandler(this.FrmMojeGume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeGume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMojeGume;
        private System.Windows.Forms.Button btnZatvori;
    }
}