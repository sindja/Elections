using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using IzboriApp.Entiteti;
using IzboriApp.Mapiranja;

namespace IzboriApp
{
    public partial class UnosReklamniProstor : Form
    {
        Glavna g;
        public UnosReklamniProstor(Glavna f)
        {
            InitializeComponent();
            g = f;
        }

        private void radioButtonPanoi_CheckedChanged(object sender, EventArgs e)
        {
            labelGrad.Visible = true;
            labelAdresa.Visible = true;
            labelPovrsina.Visible = true;
            labelAgencija.Visible = true;
            textBoxGrad.Visible = true;
            textBoxAdresa.Visible = true;
            textBoxPovrsina.Visible = true;
            textBoxAgencija.Visible = true;

            labelTrajanje.Visible = false;
            labelTV.Visible = false;
            labelEmitovanja.Visible = false;
            textBoxTrajanje.Visible = false;
            textBoxTV.Visible = false;
            textBoxEmitovanja.Visible = false;

            labelList.Visible = false;
            labelKolor.Visible = false;
            textBoxList.Visible = false;
            textBoxKolor.Visible = false;
        }

        private void radioButtonTV_CheckedChanged(object sender, EventArgs e)
        {
            labelGrad.Visible = false;
            labelAdresa.Visible = false;
            labelPovrsina.Visible = false;
            labelAgencija.Visible = false;
            textBoxGrad.Visible = false;
            textBoxAdresa.Visible = false;
            textBoxPovrsina.Visible = false;
            textBoxAgencija.Visible = false;

            labelTrajanje.Visible = true;
            labelTV.Visible = true;
            labelEmitovanja.Visible = true;
            textBoxTrajanje.Visible = true;
            textBoxTV.Visible = true;
            textBoxEmitovanja.Visible = true;

            labelList.Visible = false;
            labelKolor.Visible = false;
            textBoxList.Visible = false;
            textBoxKolor.Visible = false;
        }

        private void radioButtonStampa_CheckedChanged(object sender, EventArgs e)
        {
            labelGrad.Visible = false;
            labelAdresa.Visible = false;
            labelPovrsina.Visible = false;
            labelAgencija.Visible = false;
            textBoxGrad.Visible = false;
            textBoxAdresa.Visible = false;
            textBoxPovrsina.Visible = false;
            textBoxAgencija.Visible = false;

            labelTrajanje.Visible = false;
            labelTV.Visible = false;
            labelEmitovanja.Visible = false;
            textBoxTrajanje.Visible = false;
            textBoxTV.Visible = false;
            textBoxEmitovanja.Visible = false;

            labelList.Visible = true;
            labelKolor.Visible = true;
            textBoxList.Visible = true;
            textBoxKolor.Visible = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (radioButtonStampa.Checked)
                {
                    Stampa st = new Stampa();
                    st.nazivLista = textBoxList.Text;
                    st.kolor = textBoxKolor.Text;
                    st.iznos = Convert.ToInt32(textBoxIznos.Text);
                    st.pocetakReklamiranja = dateTimePicker1.Value;
                    st.krajReklamiranja = dateTimePicker2.Value;

                    s.Save(st);
                }
                else if (radioButtonPanoi.Checked)
                {
                    Panoi pn = new Panoi();
                    pn.grad = textBoxGrad.Text;
                    pn.nazivAgencije = textBoxAgencija.Text;
                    pn.adresa = textBoxAdresa.Text;
                    pn.povrsinaPanoa = Convert.ToInt16(textBoxPovrsina.Text);
                    pn.iznos = Convert.ToInt32(textBoxIznos.Text);
                    pn.pocetakReklamiranja = dateTimePicker1.Value;
                    pn.krajReklamiranja = dateTimePicker2.Value;

                    s.Save(pn);
                }
                else if (radioButtonTV.Checked)
                {
                    R_TV rt = new R_TV();
                    rt.nazivStanice = textBoxTV.Text;
                    rt.trajanje = Convert.ToInt32(textBoxTrajanje.Text);
                    rt.brojEmitovanja = Convert.ToInt16(textBoxEmitovanja.Text);
                    rt.iznos = Convert.ToInt32(textBoxIznos.Text);
                    rt.pocetakReklamiranja = dateTimePicker1.Value;
                    rt.krajReklamiranja = dateTimePicker2.Value;

                    s.Save(rt);
                }

                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali podatke u bazu.");

                g.RefreshGridPanoi();
                g.RefreshGridR_TV();
                g.RefreshGridStampa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
