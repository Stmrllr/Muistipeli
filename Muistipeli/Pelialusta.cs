using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class Pelialusta : Form
    {
        // Random-olion luominen ruudukon ikonien valintaan
        private readonly Random random = new Random();

        // Tieto pelaajien vuoroista (1 = pelaaja 1, 2 = pelaaja 2) sekä pelaajien pistemäärästä
        private int vuoro = 1;
        private int p1Pisteet = 0;
        private int p2Pisteet = 0;
        private int p1Ind;
        private int p2Ind;
        private string pelaaja1;
        private string pelaaja2;
        private int pelimoodi;

        // Klikit-muuttujassa tieto klikkausten määrästä. Tätä tietoa käytetään yksinpelin tuloksen ilmoittamiseen.
        private int klikit;

        // Muistipeli käyttää ikoneina Webdings-fonttia, jossa kukin kirjain on erilainen ikoni.
        // Listan kukin kirjain esiintyy pareittain, koska pelissä on aina kaksi kappaletta kutakin ikonia.
        List<string> ikonit = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z",
        "@", "@", "U", "U", "c", "c", "%", "%",
        "=", "=", "-", "-", "g", "g", "Y", "Y",
        "i", "i", "j", "j"
    };
        public Pelialusta(Alkuvalikko alkuV)
        {
            InitializeComponent();
            pelimoodi = alkuV.pelimoodi;

            // Piilotetaan alapaneeli, jos pelimoodi == yksinpeli
            if (pelimoodi == 1)
            {
                alaPanel.Visible = false;
            }
            // Muutetaan tablelayoutpanelin kokoa sekä labelien määrää pelialustan kokovalinnan mukaan
            if (alkuV.rBtn6x5.Checked == true)
            {
                tlopPelialusta.RowCount = 5;
                for (int i = 31; i <= 36; i++)
                {
                    Label lbl = this.Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Dispose();
                    }
                }
                // Pienennetään ikonitaulukkoa
                ikonit.RemoveRange(0, 6);
            }
            else if (alkuV.rBtn6x4.Checked == true)
            {
                tlopPelialusta.RowCount = 4;
                for (int i = 25; i <= 36; i++)
                {
                    Label lbl = this.Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Dispose();
                    }
                }
                ikonit.RemoveRange(0, 12);
            }
            else if (alkuV.rBtn4x4.Checked == true)
            {
                tlopPelialusta.ColumnCount = 4;
                tlopPelialusta.RowCount = 4;
                for (int i = 17; i <= 36; i++)
                {
                    Label lbl = this.Controls.Find("label" + i.ToString(), true).FirstOrDefault() as Label;
                    if (lbl != null)
                    {
                        lbl.Dispose();
                    }
                }
                ikonit.RemoveRange(0, 20);
            }

            AssignIconsToSquares();

            p1Ind = alkuV.cBoxPelaaja1.SelectedIndex;
            p2Ind = alkuV.cBoxPelaaja2.SelectedIndex;

            bLabel2.Visible = false;
            pelaaja1 = alkuV.cBoxPelaaja1.Text;
            pelaaja2 = alkuV.cBoxPelaaja2.Text;
            bLabel1.Text = pelaaja1 + "n vuoro!";
            bLabel2.Text = pelaaja2 + "n vuoro!";
            bLabelPisteet1.Text = alkuV.cBoxPelaaja1.Text + ": " + p1Pisteet.ToString();
            bLabelPisteet2.Text = alkuV.cBoxPelaaja2.Text + ": " + p2Pisteet.ToString();
        }

        // Ikonit listasta satunnaisessa järjestyksessä pelialustalle (labeleihin)
        private void AssignIconsToSquares()
        {
            foreach (Control control in tlopPelialusta.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(ikonit.Count);
                    iconLabel.Text = ikonit[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    ikonit.RemoveAt(randomNumber);
                }
            }
        }
        // Jos ei olla vielä klikattu mitään ruutua
        Label ekaClicked = null;
        Label tokaClicked = null;

        // Event handler jokaiselle klikille
        private void Label_Click(object sender, EventArgs e)
        {
            // pidetään kirjaa yksinpelin klikkimäärästä
            klikit++;

            // jos timer on käynnissä (vuoro vaihtumassa), estetään klikkaukset
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // Klikattua ruutua ruutua ei voi klikata uusiksi
                if (clickedLabel.ForeColor == Color.White)
                    return;

                // Ensimmäinen klikattu ruutu
                if (ekaClicked == null)
                {
                    ekaClicked = clickedLabel;
                    ekaClicked.ForeColor = Color.White;

                    return;
                }

                // Toinen ruutu
                tokaClicked = clickedLabel;
                tokaClicked.ForeColor = Color.White;

                // Tarkastetaan onko kaikki ruudut löydetty
                CheckForWinner();

                // Jos pelaaja valitsi kaksi samaa ruutua
                if (ekaClicked.Text == tokaClicked.Text)
                {
                    ekaClicked = null;
                    tokaClicked = null;

                    if (vuoro == 1)
                    {
                        p1Pisteet++;
                        bLabelPisteet1.Text = pelaaja1 + ": " + p1Pisteet.ToString();
                    }
                    else if (vuoro == 2)
                    {
                        p2Pisteet++;
                        bLabelPisteet2.Text = pelaaja2 + ": " + p2Pisteet.ToString();
                    }
                    return;
                }

                // Jos paria ei löytynyt, startataan timer ja piilotetaan avatut ruudut.
                // Timer on asetettu pyörimään 1000ms, eli ikonit näkyvät vuoron vaihtuessa yhden sekunnin ajan.
                if (vuoro == 1)
                {
                    vuoro = 2;
                    alaPanel.BackColor = Color.DeepSkyBlue;
                }
                else if (vuoro == 2)
                {
                    vuoro = 1;
                    alaPanel.BackColor = Color.LightSkyBlue;
                }
                timer1.Start();
                TarkastaVuoro(vuoro);
                MuutaVuoronTeksti();
            }
        }

        // Tarkastetaan onko kaikki parit löydetty (käydään kaikki tablelayoutpanelin ruudut läpi)
        private void CheckForWinner()
        {
            foreach (Control control in tlopPelialusta.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            // Kasvatetaan pisteet-muuttujia parien löytämisen jälkeen
            if (vuoro == 1 && pelimoodi == 2)
            {
                p1Pisteet++;
                bLabelPisteet1.Text = pelaaja1 + ": " + p1Pisteet.ToString();
            }
            else if (vuoro == 2 && pelimoodi == 2)
            {
                p2Pisteet++;
                bLabelPisteet2.Text = pelaaja2 + ": " + p2Pisteet.ToString();
            }
            // Jos looppi ei palautunut, kaikki parit on löydetty ja peli loppuu
            if (pelimoodi == 1)
            {
                MessageBox.Show("Ratkaisit yksinpelin " + klikit + " klikkauksella!", "Peli päättyi!");
            }
            if (pelimoodi == 2)
            {
                MessageBox.Show("Pisteet\n\n" + pelaaja1 + ": " + p1Pisteet + "\n" + pelaaja2 + ": " + p2Pisteet, "Peli päättyi!");
            }

            // Suljetaan pelialusta, mutta ei käytetä sen FormClosing-toimintoa.
            // FormClosing toimii vain, jos pelialusta halutaan sulkea kesken pelin.
            this.FormClosing -= Pelialusta_FormClosing;
            this.Close();

            Alkuvalikko alkuvalikko = new Alkuvalikko();
            alkuvalikko.Show();
           
            // Lisätään voitot/tappiot pelaajalistaan ja kirjoitetaan .XML-tiedostoon
            if (p1Pisteet > p2Pisteet && pelimoodi == 2)
            {
                alkuvalikko.pelaajaLista[p1Ind].Voitot++;
                alkuvalikko.pelaajaLista[p2Ind].Tappiot++;
            }
            else if (p2Pisteet > p1Pisteet && pelimoodi == 2)
            {
                alkuvalikko.pelaajaLista[p1Ind].Tappiot++;
                alkuvalikko.pelaajaLista[p2Ind].Voitot++;
            }
            StaattisetMetodit.SerializeXML(alkuvalikko.pelaajaLista);
        }

        // Tällä metodilla tarkastetaan vuoro, jos ei löydetty paria
        private int TarkastaVuoro(int vuoro)
        {
            if (vuoro == 1)
            {
                return 2;
            }
            return 1;
        }

        // Kaksinpelissä muutetaan alapaneelin labeleita vuoron mukaan
        private void MuutaVuoronTeksti()
        {
            if (bLabel1.Visible == true)
            {
                bLabel1.Visible = false;
                bLabel2.Visible = true;
            }
            else if (bLabel2.Visible == true)
            {
                bLabel1.Visible = true;
                bLabel2.Visible = false;
            }
        }

        // Timer starttaa aina kun on klikattu kaksi ruutua, mutta paria ei löytynyt
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            // Piilotetaan molemmat ruudut
            ekaClicked.ForeColor = ekaClicked.BackColor;
            tokaClicked.ForeColor = tokaClicked.BackColor;

            // Resetoidaan eka- ja tokaClicked, jotta ohjelma tietää että seuraava klikkaus on taas ensimmäinen klikkaus
            ekaClicked = null;
            tokaClicked = null;
        }

        // Messagebox kun painetaan oikean yläkulman sulje-näppäintä (X)
        private void Pelialusta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Haluatko varmasti keskeyttää pelin?", "Pelin keskeytys", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
                this.Dispose();
                Alkuvalikko alkuvalikko = new Alkuvalikko();
                alkuvalikko.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
