using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Muistipeli
{
    public static class StaattisetMetodit
    {
        // Kasasin tähän luokkaan (miltei) kaikki staattiset metodit,
        // jotta muiden luokkien koodia olisi hieman helpompi lukea

        private static readonly string tiedostonimi = "Pelaajat.xml";
        private static readonly BindingSource bs1 = new BindingSource();
        private static readonly BindingSource bs2 = new BindingSource();

        // Alustetaan alkuvalikon tiedot, comboboxi(e)n arvot, radiobuttonien näkyvyydet pelaajalistan mukaan,
        // buttonien aktiivisuus/inaktiivisuus, jne.
        public static void AlustaAlkuvalikko(Alkuvalikko alku)
        {
            alku.lblLisaaNimi.Visible = false;
            alku.lblNimi.Visible = false;
            alku.tbNimi.Visible = false;
            alku.btnLisaa.Visible = false;
            alku.lblDuelVersion.Visible = false;

            try
            {
                if (File.Exists(tiedostonimi))
                {
                    alku.pelaajaLista = DeserializeXML();
                    alku.cBoxPelaaja1.Refresh();
                    alku.cBoxPelaaja2.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe luettaessa tiedostoa!\n" + ex.Message);
            }

            if (alku.pelaajaLista.Count == 0)
            {
                alku.lblPelaajat.Visible = false;
                alku.vsLabel.Visible = false;
                alku.cBoxPelaaja1.Visible = false;
                alku.cBoxPelaaja2.Visible = false;
                alku.rBtnKaksin.Visible = false;

                alku.btnAloita.Enabled = false;
                alku.btnAloita.BackColor = System.Drawing.Color.Gray;

                alku.poistaPelaajiaToolStripMenuItem.Enabled = false;
                alku.poistaPelaajiaToolStripMenuItem.ForeColor = Color.Gray;

                alku.tsmTilastot.Enabled = false;
                alku.tsmTilastot.ForeColor = Color.Gray;

            }

            if (alku.pelaajaLista.Count == 1)
            {
                alku.btnAloita.Enabled = true;
                alku.btnAloita.BackColor = System.Drawing.Color.LimeGreen;

                alku.poistaPelaajiaToolStripMenuItem.Enabled = true;
                alku.poistaPelaajiaToolStripMenuItem.ForeColor = Color.White;

                alku.tsmTilastot.Enabled = true;
                alku.tsmTilastot.ForeColor = Color.White;

                alku.lblPelaajat.Visible = true;
                alku.vsLabel.Visible = false;
                alku.rBtnKaksin.Visible = false;
                alku.cBoxPelaaja2.Visible = false;
            }

            bs1.DataSource = alku.pelaajaLista;
            bs2.DataSource = alku.pelaajaLista;

            alku.cBoxPelaaja1.DataSource = bs1;
            alku.cBoxPelaaja1.DisplayMember = "nimi";
            alku.cBoxPelaaja1.ValueMember = "nimi";

            alku.cBoxPelaaja2.DataSource = bs2;
            alku.cBoxPelaaja2.DisplayMember = "nimi";
            alku.cBoxPelaaja2.ValueMember = "nimi";

            if (alku.pelaajaLista.Count > 1)
            {
                alku.cBoxPelaaja1.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 2].Nimi;
                alku.cBoxPelaaja2.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 1].Nimi;
                alku.vsLabel.Visible = true;
                alku.rBtnKaksin.Visible = true;
                alku.cBoxPelaaja2.Visible = true;
                alku.lblPelaajat.Visible = true;

                alku.poistaPelaajiaToolStripMenuItem.Enabled = true;
                alku.poistaPelaajiaToolStripMenuItem.ForeColor = Color.White;

                alku.tsmTilastot.Enabled = true;
                alku.tsmTilastot.ForeColor = Color.White;
            }

            if (alku.rBtnYksin.Checked)
            {
                alku.vsLabel.Visible = false;
                alku.cBoxPelaaja2.Visible = false;
            }
        }
        // LisaaPelaaja-buttonin toiminta, alkuvalikon tietojen alustaminen/päivitys buttonin painamisen jälkeen
        public static void LisaaPelaaja(Alkuvalikko alku)
        {
            for (int i = 0; i < alku.pelaajaLista.Count; i++)
            {
                if (alku.pelaajaLista[i].Nimi == alku.tbNimi.Text)
                {
                    MessageBox.Show("Tämän niminen pelaaja on jo listalla!");
                    alku.btnLisaaPelaaja.Visible = true;
                    return;
                }
            }
            alku.pelaajaLista.Add(new Pelaaja(alku.tbNimi.Text));

            alku.cBoxPelaaja1.DataSource = null;
            alku.cBoxPelaaja1.DataSource = bs1;
            alku.cBoxPelaaja1.DisplayMember = "Nimi";
            alku.cBoxPelaaja1.ValueMember = "Nimi";

            alku.cBoxPelaaja2.DataSource = null;
            alku.cBoxPelaaja2.DataSource = bs2;
            alku.cBoxPelaaja2.DisplayMember = "Nimi";
            alku.cBoxPelaaja2.ValueMember = "Nimi";

            if (alku.pelaajaLista.Count == 1)
            {
                alku.cBoxPelaaja1.Text = alku.pelaajaLista[0].Nimi;
                alku.cBoxPelaaja1.Visible = true;
            }
            // Uusia pelaajia lisättäessä joka toinen menee combobox1:en ja joka toinen combobox2:en näkymään
            if (alku.pelaajaLista.Count % 2 == 0)
            {
                alku.cBoxPelaaja1.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 2].Nimi;
                alku.cBoxPelaaja2.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 1].Nimi;
            }
            if (alku.pelaajaLista.Count % 2 == 1 && alku.pelaajaLista.Count > 1)
            {
                alku.cBoxPelaaja1.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 1].Nimi;
                alku.cBoxPelaaja2.Text = alku.pelaajaLista[alku.pelaajaLista.Count() - 2].Nimi;
            }
            if (alku.cBoxPelaaja1.Text != "")
            {
                alku.btnAloita.Enabled = true;
                alku.btnAloita.BackColor = Color.LimeGreen;
            }
            if (alku.pelaajaLista.Count > 1)
            {
                alku.rBtnKaksin.Visible = true;
            }
            alku.lblLisaaNimi.Visible = false;
            alku.lblNimi.Visible = false;
            alku.tbNimi.Visible = false;
            alku.btnLisaa.Visible = false;

            alku.btnLisaaPelaaja.Visible = true;

            SerializeXML(alku.pelaajaLista);

            alku.cBoxPelaaja1.Refresh();
            alku.cBoxPelaaja2.Refresh();

            alku.tbNimi.Text = "";
        }

        // Tätä metodia käytetään pelaajalistan tietojen kirjoittamiseen .XML-tiedostoon
        public static List<Pelaaja> DeserializeXML()
        {
            try
            {
                if (File.Exists(tiedostonimi))
                {
                    StreamReader stream = new StreamReader(tiedostonimi);
                    XmlSerializer ser = new XmlSerializer(typeof(List<Pelaaja>));
                    object obj = ser.Deserialize(stream);
                    stream.Close();
                    return (List<Pelaaja>)obj;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe luettaessa tiedostoa!\n" + ex.Message);
                return null;
            }
        }

        // Tätä metodia käytetään pelaajalistan tietojen lukemiseen .XML-tiedostosta
        public static void SerializeXML(List<Pelaaja> input)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(input.GetType());
                var sw = new StreamWriter(tiedostonimi);
                serializer.Serialize(sw, input);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe kirjoitettaessa tiedostoon!\n" + ex.Message);
            }
        }
    }
}
