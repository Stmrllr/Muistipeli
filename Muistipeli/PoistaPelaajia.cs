using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class PoistaPelaajia : Form
    {
        // Paikallinen muuttuja, johon tuotu pelaajalista luetaan
        private static List<Pelaaja> pl = new List<Pelaaja>();
        public PoistaPelaajia(List<Pelaaja> pelaajaLista)
        {
            InitializeComponent();

            cBoxPoistaPelaaja.DataSource = pelaajaLista;
            cBoxPoistaPelaaja.DisplayMember = "nimi";
            cBoxPoistaPelaaja.ValueMember = "nimi";
            pl = pelaajaLista;
        }
        // Poista pelaaja -buttonin toiminta
        private void BtnPoista_Click(object sender, EventArgs e)
        {
            string message = "Haluatko varmasti poistaa pelaajan " + pl[cBoxPoistaPelaaja.SelectedIndex].Nimi + "?";
            const string caption = "Pelaajan poistaminen";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                pl.RemoveAt(cBoxPoistaPelaaja.SelectedIndex);
                StaattisetMetodit.SerializeXML(pl);
                cBoxPoistaPelaaja.DataSource = null;
                cBoxPoistaPelaaja.DataSource = pl;
                cBoxPoistaPelaaja.DisplayMember = "nimi";
                cBoxPoistaPelaaja.ValueMember = "nimi";
                cBoxPoistaPelaaja.Refresh();
            }
            else if (result == DialogResult.No)
            {
                return;
            }

            if (pl.Count > 0)
            {
                cBoxPoistaPelaaja.Refresh();
                cBoxPoistaPelaaja.SelectedValue = pl[pl.Count - 1].Nimi;
            }
            else if (pl.Count == 0)
            {
                this.Close();
                Alkuvalikko alkuV = new Alkuvalikko();
                alkuV.Refresh();
                alkuV.Show();
            }
        }
        // Palaa alkuvalikkoon -button
        private void btnPalaa_Click(object sender, EventArgs e)
        {
            this.Close();
            Alkuvalikko alkuV = new Alkuvalikko();
            StaattisetMetodit.AlustaAlkuvalikko(alkuV);
            alkuV.Refresh();
            alkuV.Show();
        }
    }
}
