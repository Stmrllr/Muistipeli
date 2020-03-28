namespace Muistipeli
{
    partial class Alkuvalikko
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
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.lblRuudukonKoko = new System.Windows.Forms.Label();
            this.rBtn4x4 = new System.Windows.Forms.RadioButton();
            this.rBtn6x4 = new System.Windows.Forms.RadioButton();
            this.rBtn6x5 = new System.Windows.Forms.RadioButton();
            this.rBtn6x6 = new System.Windows.Forms.RadioButton();
            this.lblPelaajat = new System.Windows.Forms.Label();
            this.lblNimi = new System.Windows.Forms.Label();
            this.lblLisaaNimi = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnLisaaPelaaja = new System.Windows.Forms.Button();
            this.btnAloita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPelaaja1 = new System.Windows.Forms.ComboBox();
            this.vsLabel = new System.Windows.Forms.Label();
            this.cBoxPelaaja2 = new System.Windows.Forms.ComboBox();
            this.lblDuelVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTilastot = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaPelaajiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPoistu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBtnKaksin = new System.Windows.Forms.RadioButton();
            this.rBtnYksin = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOtsikko
            // 
            this.lblOtsikko.AutoSize = true;
            this.lblOtsikko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOtsikko.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtsikko.ForeColor = System.Drawing.Color.White;
            this.lblOtsikko.Location = new System.Drawing.Point(144, 79);
            this.lblOtsikko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(436, 91);
            this.lblOtsikko.TabIndex = 0;
            this.lblOtsikko.Text = "Muistipeli";
            this.lblOtsikko.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRuudukonKoko
            // 
            this.lblRuudukonKoko.AutoSize = true;
            this.lblRuudukonKoko.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuudukonKoko.ForeColor = System.Drawing.Color.White;
            this.lblRuudukonKoko.Location = new System.Drawing.Point(56, 0);
            this.lblRuudukonKoko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRuudukonKoko.Name = "lblRuudukonKoko";
            this.lblRuudukonKoko.Size = new System.Drawing.Size(281, 31);
            this.lblRuudukonKoko.TabIndex = 1;
            this.lblRuudukonKoko.Text = "Valitse ruudukon koko";
            // 
            // rBtn4x4
            // 
            this.rBtn4x4.AutoSize = true;
            this.rBtn4x4.Checked = true;
            this.rBtn4x4.ForeColor = System.Drawing.Color.White;
            this.rBtn4x4.Location = new System.Drawing.Point(48, 49);
            this.rBtn4x4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtn4x4.Name = "rBtn4x4";
            this.rBtn4x4.Size = new System.Drawing.Size(90, 29);
            this.rBtn4x4.TabIndex = 3;
            this.rBtn4x4.TabStop = true;
            this.rBtn4x4.Text = "4 x 4";
            this.rBtn4x4.UseVisualStyleBackColor = true;
            // 
            // rBtn6x4
            // 
            this.rBtn6x4.AutoSize = true;
            this.rBtn6x4.ForeColor = System.Drawing.Color.White;
            this.rBtn6x4.Location = new System.Drawing.Point(232, 49);
            this.rBtn6x4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtn6x4.Name = "rBtn6x4";
            this.rBtn6x4.Size = new System.Drawing.Size(90, 29);
            this.rBtn6x4.TabIndex = 4;
            this.rBtn6x4.Text = "6 x 4";
            this.rBtn6x4.UseVisualStyleBackColor = true;
            // 
            // rBtn6x5
            // 
            this.rBtn6x5.AutoSize = true;
            this.rBtn6x5.ForeColor = System.Drawing.Color.White;
            this.rBtn6x5.Location = new System.Drawing.Point(48, 102);
            this.rBtn6x5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtn6x5.Name = "rBtn6x5";
            this.rBtn6x5.Size = new System.Drawing.Size(90, 29);
            this.rBtn6x5.TabIndex = 5;
            this.rBtn6x5.Text = "6 x 5";
            this.rBtn6x5.UseVisualStyleBackColor = true;
            // 
            // rBtn6x6
            // 
            this.rBtn6x6.AutoSize = true;
            this.rBtn6x6.ForeColor = System.Drawing.Color.White;
            this.rBtn6x6.Location = new System.Drawing.Point(232, 102);
            this.rBtn6x6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtn6x6.Name = "rBtn6x6";
            this.rBtn6x6.Size = new System.Drawing.Size(90, 29);
            this.rBtn6x6.TabIndex = 6;
            this.rBtn6x6.Text = "6 x 6";
            this.rBtn6x6.UseVisualStyleBackColor = true;
            // 
            // lblPelaajat
            // 
            this.lblPelaajat.AutoSize = true;
            this.lblPelaajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPelaajat.ForeColor = System.Drawing.Color.White;
            this.lblPelaajat.Location = new System.Drawing.Point(265, 584);
            this.lblPelaajat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPelaajat.Name = "lblPelaajat";
            this.lblPelaajat.Size = new System.Drawing.Size(190, 31);
            this.lblPelaajat.TabIndex = 7;
            this.lblPelaajat.Text = "Valitse pelaaja";
            // 
            // lblNimi
            // 
            this.lblNimi.AutoSize = true;
            this.lblNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNimi.ForeColor = System.Drawing.Color.White;
            this.lblNimi.Location = new System.Drawing.Point(160, 502);
            this.lblNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNimi.Name = "lblNimi";
            this.lblNimi.Size = new System.Drawing.Size(68, 31);
            this.lblNimi.TabIndex = 9;
            this.lblNimi.Text = "Nimi";
            // 
            // lblLisaaNimi
            // 
            this.lblLisaaNimi.AutoSize = true;
            this.lblLisaaNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLisaaNimi.ForeColor = System.Drawing.Color.White;
            this.lblLisaaNimi.Location = new System.Drawing.Point(228, 449);
            this.lblLisaaNimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLisaaNimi.Name = "lblLisaaNimi";
            this.lblLisaaNimi.Size = new System.Drawing.Size(230, 31);
            this.lblLisaaNimi.TabIndex = 8;
            this.lblLisaaNimi.Text = "Lisää uusi pelaaja";
            // 
            // tbNimi
            // 
            this.tbNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNimi.Location = new System.Drawing.Point(235, 499);
            this.tbNimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(216, 38);
            this.tbNimi.TabIndex = 10;
            this.tbNimi.TextChanged += new System.EventHandler(this.TbNimi_TextChanged);
            // 
            // btnLisaa
            // 
            this.btnLisaa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.ForeColor = System.Drawing.Color.White;
            this.btnLisaa.Location = new System.Drawing.Point(477, 494);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(112, 55);
            this.btnLisaa.TabIndex = 11;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.UseVisualStyleBackColor = false;
            this.btnLisaa.Click += new System.EventHandler(this.BtnLisaa_Click);
            // 
            // btnLisaaPelaaja
            // 
            this.btnLisaaPelaaja.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLisaaPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaPelaaja.ForeColor = System.Drawing.Color.White;
            this.btnLisaaPelaaja.Location = new System.Drawing.Point(228, 425);
            this.btnLisaaPelaaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLisaaPelaaja.Name = "btnLisaaPelaaja";
            this.btnLisaaPelaaja.Size = new System.Drawing.Size(267, 124);
            this.btnLisaaPelaaja.TabIndex = 12;
            this.btnLisaaPelaaja.Text = "Lisää pelaaja";
            this.btnLisaaPelaaja.UseVisualStyleBackColor = false;
            this.btnLisaaPelaaja.Click += new System.EventHandler(this.BtnLisaaPelaaja_Click);
            // 
            // btnAloita
            // 
            this.btnAloita.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAloita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAloita.ForeColor = System.Drawing.Color.White;
            this.btnAloita.Location = new System.Drawing.Point(185, 865);
            this.btnAloita.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAloita.Name = "btnAloita";
            this.btnAloita.Size = new System.Drawing.Size(353, 96);
            this.btnAloita.TabIndex = 13;
            this.btnAloita.Text = "Aloita peli";
            this.btnAloita.UseVisualStyleBackColor = false;
            this.btnAloita.Click += new System.EventHandler(this.BtnAloita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 998);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "© Mika Penttinen 2019";
            // 
            // cBoxPelaaja1
            // 
            this.cBoxPelaaja1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPelaaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPelaaja1.FormattingEnabled = true;
            this.cBoxPelaaja1.Location = new System.Drawing.Point(100, 645);
            this.cBoxPelaaja1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxPelaaja1.Name = "cBoxPelaaja1";
            this.cBoxPelaaja1.Size = new System.Drawing.Size(199, 45);
            this.cBoxPelaaja1.TabIndex = 18;
            this.cBoxPelaaja1.SelectedIndexChanged += new System.EventHandler(this.CBoxPelaaja1_SelectedIndexChanged);
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.ForeColor = System.Drawing.Color.White;
            this.vsLabel.Location = new System.Drawing.Point(328, 649);
            this.vsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(62, 37);
            this.vsLabel.TabIndex = 20;
            this.vsLabel.Text = "VS";
            // 
            // cBoxPelaaja2
            // 
            this.cBoxPelaaja2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPelaaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxPelaaja2.FormattingEnabled = true;
            this.cBoxPelaaja2.Location = new System.Drawing.Point(413, 645);
            this.cBoxPelaaja2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxPelaaja2.Name = "cBoxPelaaja2";
            this.cBoxPelaaja2.Size = new System.Drawing.Size(199, 45);
            this.cBoxPelaaja2.TabIndex = 21;
            this.cBoxPelaaja2.SelectedIndexChanged += new System.EventHandler(this.CBoxPelaaja1_SelectedIndexChanged);
            // 
            // lblDuelVersion
            // 
            this.lblDuelVersion.AutoSize = true;
            this.lblDuelVersion.ForeColor = System.Drawing.Color.White;
            this.lblDuelVersion.Location = new System.Drawing.Point(435, 140);
            this.lblDuelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuelVersion.Name = "lblDuelVersion";
            this.lblDuelVersion.Size = new System.Drawing.Size(126, 25);
            this.lblDuelVersion.TabIndex = 22;
            this.lblDuelVersion.Text = "duelVersion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(719, 35);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTilastot,
            this.poistaPelaajiaToolStripMenuItem,
            this.tsmPoistu});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 31);
            this.toolStripMenuItem1.Text = "Valikko";
            // 
            // tsmTilastot
            // 
            this.tsmTilastot.BackColor = System.Drawing.Color.SteelBlue;
            this.tsmTilastot.ForeColor = System.Drawing.Color.White;
            this.tsmTilastot.Name = "tsmTilastot";
            this.tsmTilastot.Size = new System.Drawing.Size(359, 44);
            this.tsmTilastot.Text = "Pelitilastot";
            this.tsmTilastot.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // poistaPelaajiaToolStripMenuItem
            // 
            this.poistaPelaajiaToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.poistaPelaajiaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.poistaPelaajiaToolStripMenuItem.Name = "poistaPelaajiaToolStripMenuItem";
            this.poistaPelaajiaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.poistaPelaajiaToolStripMenuItem.Text = "Poista pelaajia";
            this.poistaPelaajiaToolStripMenuItem.Click += new System.EventHandler(this.PoistaPelaajiaToolStripMenuItem_Click);
            // 
            // tsmPoistu
            // 
            this.tsmPoistu.BackColor = System.Drawing.Color.SteelBlue;
            this.tsmPoistu.ForeColor = System.Drawing.Color.White;
            this.tsmPoistu.Name = "tsmPoistu";
            this.tsmPoistu.Size = new System.Drawing.Size(359, 44);
            this.tsmPoistu.Text = "Poistu";
            this.tsmPoistu.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRuudukonKoko);
            this.panel1.Controls.Add(this.rBtn4x4);
            this.panel1.Controls.Add(this.rBtn6x4);
            this.panel1.Controls.Add(this.rBtn6x5);
            this.panel1.Controls.Add(this.rBtn6x6);
            this.panel1.Location = new System.Drawing.Point(172, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 156);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBtnKaksin);
            this.panel2.Controls.Add(this.rBtnYksin);
            this.panel2.Location = new System.Drawing.Point(172, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 66);
            this.panel2.TabIndex = 25;
            // 
            // rBtnKaksin
            // 
            this.rBtnKaksin.AutoSize = true;
            this.rBtnKaksin.ForeColor = System.Drawing.Color.White;
            this.rBtnKaksin.Location = new System.Drawing.Point(232, 16);
            this.rBtnKaksin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnKaksin.Name = "rBtnKaksin";
            this.rBtnKaksin.Size = new System.Drawing.Size(142, 29);
            this.rBtnKaksin.TabIndex = 8;
            this.rBtnKaksin.Text = "Kaksinpeli";
            this.rBtnKaksin.UseVisualStyleBackColor = true;
            this.rBtnKaksin.CheckedChanged += new System.EventHandler(this.RBtnKaksin_CheckedChanged);
            // 
            // rBtnYksin
            // 
            this.rBtnYksin.AutoSize = true;
            this.rBtnYksin.Checked = true;
            this.rBtnYksin.ForeColor = System.Drawing.Color.White;
            this.rBtnYksin.Location = new System.Drawing.Point(48, 16);
            this.rBtnYksin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnYksin.Name = "rBtnYksin";
            this.rBtnYksin.Size = new System.Drawing.Size(131, 29);
            this.rBtnYksin.TabIndex = 7;
            this.rBtnYksin.TabStop = true;
            this.rBtnYksin.Text = "Yksinpeli";
            this.rBtnYksin.UseVisualStyleBackColor = true;
            this.rBtnYksin.CheckedChanged += new System.EventHandler(this.RBtnKaksin_CheckedChanged);
            // 
            // Alkuvalikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(719, 1028);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDuelVersion);
            this.Controls.Add(this.cBoxPelaaja2);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.cBoxPelaaja1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAloita);
            this.Controls.Add(this.btnLisaaPelaaja);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.lblNimi);
            this.Controls.Add(this.lblLisaaNimi);
            this.Controls.Add(this.lblPelaajat);
            this.Controls.Add(this.lblOtsikko);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Alkuvalikko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alkuvalikko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alkuvalikko_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtsikko;
        private System.Windows.Forms.Label lblRuudukonKoko;
        public System.Windows.Forms.RadioButton rBtn4x4;
        public System.Windows.Forms.RadioButton rBtn6x4;
        public System.Windows.Forms.RadioButton rBtn6x5;
        public System.Windows.Forms.RadioButton rBtn6x6;
        public System.Windows.Forms.Label lblPelaajat;
        public System.Windows.Forms.Label lblNimi;
        public System.Windows.Forms.Label lblLisaaNimi;
        public System.Windows.Forms.TextBox tbNimi;
        public System.Windows.Forms.Button btnLisaa;
        public System.Windows.Forms.Button btnLisaaPelaaja;
        public System.Windows.Forms.Button btnAloita;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cBoxPelaaja1;
        public System.Windows.Forms.Label vsLabel;
        public System.Windows.Forms.ComboBox cBoxPelaaja2;
        public System.Windows.Forms.Label lblDuelVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rBtnYksin;
        public System.Windows.Forms.RadioButton rBtnKaksin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem tsmTilastot;
        private System.Windows.Forms.ToolStripMenuItem tsmPoistu;
        public System.Windows.Forms.ToolStripMenuItem poistaPelaajiaToolStripMenuItem;
    }
}