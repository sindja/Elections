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
    public partial class AktivistaUnos : Form
    {
        Glavna g;
        public AktivistaUnos(Glavna f)
        {
            InitializeComponent();
            g = f;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (checkBoxKoord.Checked == false)
                {
                    Aktivista ak = new Aktivista();

                    ak.ime = textBoxIme.Text;
                    ak.imeRoditelja = textBoxImR.Text;
                    ak.prezime = textBoxPrez.Text;
                    ak.adresa = textBoxAdr.Text;
                    ak.datumRodjenja = dateTimePickerRodj.Value;

                    foreach (string q in listBoxEmail.Items)
                    {
                        Email em = new Email();
                        em.email = q;
                        ak.email.Add(em);
                        s.Save(em);
                    }
                    foreach (string q in listBoxBrojevi.Items)
                    {
                        BrojeviTelefona br = new BrojeviTelefona();
                        br.brojevi_telefona = q;
                        ak.brojevi.Add(br);
                        s.Save(br);
                    }
                    s.Save(ak);
                }
                else if(checkBoxKoord.Checked)
                {

                Koordinator k = new Koordinator();

                k.imeOpstine = textBoxImeOps.Text;
                k.adresaKancelarije = textBoxAdrKan.Text;
                k.ime = textBoxIme.Text;
                k.imeRoditelja = textBoxImR.Text;
                k.prezime = textBoxPrez.Text;
                k.adresa = textBoxAdr.Text;
                k.datumRodjenja = dateTimePickerRodj.Value;

                foreach (string q in listBoxEmail.Items)
                {
                    Email em = new Email();
                    em.email = q;
                    k.email.Add(em);
                    s.Save(em);
                }
                foreach (string q in listBoxBrojevi.Items)
                {
                    BrojeviTelefona br = new BrojeviTelefona();
                    br.brojevi_telefona = q;
                    k.brojevi.Add(br);
                    s.Save(br);
                }
                s.Save(k);
                }
                
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali podatke u bazu.");

                g.RefreshGridAktivisti();
                textBoxAdr.Text = "";
                textBoxBrTel.Text = "";
                textBoxEmail.Text = "";
                textBoxIme.Text = "";
                textBoxImR.Text = "";
                textBoxPrez.Text = "";
                textBoxAdrKan.Text = "";
                textBoxImeOps.Text = "";
                listBoxBrojevi.Items.Clear();
                listBoxEmail.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                listBoxEmail.Items.Add(textBoxEmail.Text);
                textBoxEmail.Text = "";
            }
        }

        private void textBoxBrTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                listBoxBrojevi.Items.Add(textBoxBrTel.Text);
                textBoxBrTel.Text = "";
            }
        }

        private void checkBoxKoord_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxKoord.Checked)
                groupBoxUnapredi.Enabled = true;
            else
                groupBoxUnapredi.Enabled = false;

        }
    }
}
