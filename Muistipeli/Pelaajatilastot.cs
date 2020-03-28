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
    public partial class Pelaajatilastot : Form
    {
        int ind = 0;
        int y = 12;
        int indV = 0;
        int y2 = 29;
        int indH = 0;
        int y3 = 44;

        public Pelaajatilastot(List<Pelaaja> lista)
        {
            InitializeComponent();

            lblPelaaja.Visible = false;
            lblVoitot.Visible = false;
            lblHaviot.Visible = false;
          
            // luodaan pelaajan nimi / häviöt / voitot -labelit jokaiselle listan pelaajalle
            foreach (object pelaaja in lista)
            {
                lblPelaaja = new Label();
                lblVoitot = new Label();
                lblHaviot = new Label();

                //lblPelaaja
                lblPelaaja.Text = lista[0].Nimi;
                lblPelaaja.AutoSize = true;
                lblPelaaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblPelaaja.ForeColor = System.Drawing.Color.White;
                lblPelaaja.Location = new System.Drawing.Point(12, y);
                y += 60;
                lblPelaaja.Name = "lblPelaaja";
                lblPelaaja.Size = new System.Drawing.Size(64, 25);
                lblPelaaja.TabIndex = 0;
                lblPelaaja.Text = lista[ind].Nimi;
                ind++;

                //lblVoitot
                lblVoitot.AutoSize = true;
                lblVoitot.ForeColor = System.Drawing.Color.White;
                lblVoitot.Location = new System.Drawing.Point(12, y2);
                y2 += 60;
                lblVoitot.Name = "lblVoitot";
                lblVoitot.Size = new System.Drawing.Size(51, 20);
                lblVoitot.TabIndex = 1;
                lblVoitot.Text = "Voitot: " + lista[indV].Voitot.ToString();
                indV++;

                //lblHaviot
                lblHaviot.AutoSize = true;
                lblHaviot.ForeColor = System.Drawing.Color.White;
                lblHaviot.Location = new System.Drawing.Point(12, y3);
                y3 += 60;
                lblHaviot.Name = "lblHaviot";
                lblHaviot.Size = new System.Drawing.Size(51, 20);
                lblHaviot.TabIndex = 2;
                lblHaviot.Text = "Häviöt :" + lista[indH].Tappiot.ToString();
                indH++;

                //lisätään kontrollit formiin
                Controls.Add(lblPelaaja);
                Controls.Add(lblVoitot);
                Controls.Add(lblHaviot);
            }

        }
    }
}
