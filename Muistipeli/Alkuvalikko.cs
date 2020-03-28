using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Alkuvalikko : Form
    {
        // Lista pelaaja-olioista. Tämä lista kirjoitetaan/luetaan .XML-tiedostoon/tiedostosta
        public List<Pelaaja> pelaajaLista = new List<Pelaaja>();

        // Pelimoodi-muuttujassa tieto yksin/kaksinpelistä
        public int pelimoodi;

        public Alkuvalikko()
        {
            InitializeComponent();

            // Kutsutaan staattista metodia, jolla alustetaan alkuvalikon näkymä
            // pelaajalistan olioiden lukumäärän mukaan
            StaattisetMetodit.AlustaAlkuvalikko(this);
        }
        // "Lisää pelaaja" -buttonin toiminta. Piilotetaan tiettyjä elementtejä,
        // koska alkuvalikko-formin toiminta on tehty "single page app" -tyyliseksi
        private void BtnLisaaPelaaja_Click(object sender, EventArgs e)
        {
            lblLisaaNimi.Visible = true;
            lblNimi.Visible = true;
            tbNimi.Visible = true;
            btnLisaa.Visible = true;

            btnLisaaPelaaja.Visible = false;

            btnLisaa.Enabled = false;
            btnLisaa.BackColor = System.Drawing.Color.Gray;
        }
        private void BtnLisaa_Click(object sender, EventArgs e)
        {
            StaattisetMetodit.LisaaPelaaja(this);
            StaattisetMetodit.AlustaAlkuvalikko(this);
        }
        // Pelin aloitus -buttonin toiminta. Pelimoodi-muuttujaa käytetään Pelialusta-formissa
        private void BtnAloita_Click(object sender, EventArgs e)
        {
            if (rBtnYksin.Checked)
            {
                pelimoodi = 1;
                cBoxPelaaja2.Text = "";
            }
            else if (rBtnKaksin.Checked)
            {
                pelimoodi = 2;
            }

            this.Hide();
            Pelialusta pelialusta = new Pelialusta(this);
            pelialusta.Show();
        }
        // Jos "pelaajan nimi" -kenttä on tyhjä, disabloidaan "Lisää"-button
        private void TbNimi_TextChanged(object sender, EventArgs e)
        {
            if (tbNimi.Text == "")
            {
                btnLisaa.Enabled = false;
                btnLisaa.BackColor = System.Drawing.Color.Gray;
            }
            else if (tbNimi.Text != "")
            {
                btnLisaa.Enabled = true;
                btnLisaa.BackColor = Color.LimeGreen;
            }
        }
        // Näytetään/piilotetaan elementtejä pelaajalistan olioiden määrän mukaan
        private void RBtnKaksin_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnYksin.Checked && pelaajaLista.Count == 0)
            {
                cBoxPelaaja1.Visible = false;
                lblDuelVersion.Visible = false;
            }
            else if (rBtnYksin.Checked && pelaajaLista.Count > 0)
            {
                lblPelaajat.Text = "Valitse pelaaja";
                vsLabel.Visible = false;
                cBoxPelaaja1.Visible = true;
                cBoxPelaaja2.Visible = false;
                lblDuelVersion.Visible = false;

                btnAloita.Enabled = true;
                btnAloita.BackColor = Color.LimeGreen;
            }
            else if (rBtnKaksin.Checked && pelaajaLista.Count == 0)
            {
                vsLabel.Visible = false;
                cBoxPelaaja2.Visible = false;
                lblDuelVersion.Visible = true;
                vsLabel.Visible = false;
                cBoxPelaaja1.Visible = false;

            }
            else if (rBtnKaksin.Checked)
            {
                lblPelaajat.Text = "Valitse pelaajat";
                lblDuelVersion.Visible = true;
                vsLabel.Visible = true;
                cBoxPelaaja2.Visible = true;
            }
        }
        // Disabloidaan pelin aloitus -button, jos combobox1:n pelaaja == combobox2:n pelaaja 
        private void CBoxPelaaja1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rBtnKaksin.Checked && (cBoxPelaaja1.SelectedIndex == cBoxPelaaja2.SelectedIndex))
            {
                btnAloita.Enabled = false;
                btnAloita.BackColor = Color.Gray;
            }
            else
            {
                btnAloita.Enabled = true;
                btnAloita.BackColor = Color.LimeGreen;
            }
        }

        // Messagebox kun painetaan oikean yläkulman sulje-näppäintä (X)
        private void Alkuvalikko_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Haluatko varmasti lopettaa pelaamisen?";
            const string caption = "Pelin lopetus";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(1);
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Valikon "Pelaajatilastot"-toiminto
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pelaajatilastot tilastot = new Pelaajatilastot(pelaajaLista);
            tilastot.Show();
        }
     
        // Valikon "Poista pelaajia"-toiminto
        private void PoistaPelaajiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pelaajaLista.Count > 0)
            {
                this.Hide();
                PoistaPelaajia poista = new PoistaPelaajia(pelaajaLista);
                poista.Show();
            }
        }

        // Valikon "Poistu"-toiminto
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
