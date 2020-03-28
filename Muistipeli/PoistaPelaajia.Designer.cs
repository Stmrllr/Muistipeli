namespace Muistipeli
{
    partial class PoistaPelaajia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoistaPelaajia));
            this.cBoxPoistaPelaaja = new System.Windows.Forms.ComboBox();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.lblValitse = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxPoistaPelaaja
            // 
            this.cBoxPoistaPelaaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPoistaPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPoistaPelaaja.FormattingEnabled = true;
            this.cBoxPoistaPelaaja.Location = new System.Drawing.Point(29, 51);
            this.cBoxPoistaPelaaja.Name = "cBoxPoistaPelaaja";
            this.cBoxPoistaPelaaja.Size = new System.Drawing.Size(184, 37);
            this.cBoxPoistaPelaaja.TabIndex = 19;
            // 
            // btnPoista
            // 
            this.btnPoista.ForeColor = System.Drawing.Color.Black;
            this.btnPoista.Location = new System.Drawing.Point(254, 45);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(124, 52);
            this.btnPoista.TabIndex = 20;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.BtnPoista_Click);
            // 
            // btnPalaa
            // 
            this.btnPalaa.ForeColor = System.Drawing.Color.Black;
            this.btnPalaa.Location = new System.Drawing.Point(254, 160);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(124, 52);
            this.btnPalaa.TabIndex = 21;
            this.btnPalaa.Text = "Alkuvalikkoon";
            this.btnPalaa.UseVisualStyleBackColor = true;
            this.btnPalaa.Click += new System.EventHandler(this.btnPalaa_Click);
            // 
            // lblValitse
            // 
            this.lblValitse.AutoSize = true;
            this.lblValitse.Location = new System.Drawing.Point(25, 19);
            this.lblValitse.Name = "lblValitse";
            this.lblValitse.Size = new System.Drawing.Size(112, 20);
            this.lblValitse.TabIndex = 22;
            this.lblValitse.Text = "Valitse pelaaja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // PoistaPelaajia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(420, 268);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblValitse);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.cBoxPoistaPelaaja);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PoistaPelaajia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poista pelaaja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cBoxPoistaPelaaja;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnPalaa;
        private System.Windows.Forms.Label lblValitse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}