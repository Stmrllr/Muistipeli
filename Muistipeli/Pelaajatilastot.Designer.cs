namespace Muistipeli
{
    partial class Pelaajatilastot
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
            this.lblPelaaja = new System.Windows.Forms.Label();
            this.lblVoitot = new System.Windows.Forms.Label();
            this.lblHaviot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPelaaja
            // 
            this.lblPelaaja.AutoSize = true;
            this.lblPelaaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaaja.ForeColor = System.Drawing.Color.White;
            this.lblPelaaja.Location = new System.Drawing.Point(12, 9);
            this.lblPelaaja.Name = "lblPelaaja";
            this.lblPelaaja.Size = new System.Drawing.Size(66, 27);
            this.lblPelaaja.TabIndex = 0;
            this.lblPelaaja.Text = "label1";
            // 
            // lblVoitot
            // 
            this.lblVoitot.AutoSize = true;
            this.lblVoitot.ForeColor = System.Drawing.Color.White;
            this.lblVoitot.Location = new System.Drawing.Point(13, 49);
            this.lblVoitot.Name = "lblVoitot";
            this.lblVoitot.Size = new System.Drawing.Size(51, 20);
            this.lblVoitot.TabIndex = 1;
            this.lblVoitot.Text = "label1";
            // 
            // lblHaviot
            // 
            this.lblHaviot.AutoSize = true;
            this.lblHaviot.ForeColor = System.Drawing.Color.White;
            this.lblHaviot.Location = new System.Drawing.Point(13, 69);
            this.lblHaviot.Name = "lblHaviot";
            this.lblHaviot.Size = new System.Drawing.Size(51, 20);
            this.lblHaviot.TabIndex = 2;
            this.lblHaviot.Text = "label1";
            // 
            // Pelaajatilastot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(224, 448);
            this.Controls.Add(this.lblHaviot);
            this.Controls.Add(this.lblVoitot);
            this.Controls.Add(this.lblPelaaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pelaajatilastot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelaajatilastot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPelaaja;
        private System.Windows.Forms.Label lblVoitot;
        private System.Windows.Forms.Label lblHaviot;
    }
}