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
    public partial class DodajAkciju : Form
    {
        Glavna g;
        public DodajAkciju(Glavna f)
        {
            InitializeComponent();
            g = f;
        }

        private void buttonDodajAkciju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (radioButtonDeljeLet.Checked)
                {
                    DeljenjeLetaka dlj = new DeljenjeLetaka();

                    dlj.naziv = textBoxNaziv.Text;
                    dlj.grad = textBoxGrad.Text;

                    //to dodavanje ide iz glavne forme
                    /* foreach (string q in listBoxLokacije.Items)
                     {
                         Lokacije lok = new Lokacije();
                         lok.id_deljenje_letaka = dlj;
                         lok.lokacije = q;
                         dlj.lokacija.Add(lok);
                         s.Save(lok);
                     }*/

                    s.Save(dlj);
                    s.Flush();

                    s.Close();
                    MessageBox.Show("Uspesno ste dodali podatke u bazu.");

                }
                else if (radioButtonPolM.Checked)
                {
                    if (!checkBoxZatvoren.Checked)
                    {
                        PolitickiMiting pl = new PolitickiMiting();

                        pl.naziv = textBoxNaziv.Text;
                        pl.grad = textBoxGrad.Text;

                        pl.lokacija = textBoxLokacija.Text;

                        s.Save(pl);
                        s.Flush();
                        s.Close();
                        MessageBox.Show("Uspesno ste dodali podatke u bazu.");
                    }
                    else
                    {
                        ZatvoreniMiting pl = new ZatvoreniMiting();

                        pl.naziv = textBoxNaziv.Text;
                        pl.grad = textBoxGrad.Text;

                        pl.lokacija = textBoxLokacija.Text;
                        pl.iznajmljivac = textBoxIznajmlj.Text;
                        pl.cena_iznajmljivanja = Convert.ToInt32(textBoxCena.Text);

                        s.Save(pl);
                        s.Flush();
                        s.Close();
                        MessageBox.Show("Uspesno ste dodali podatke u bazu.");

                    }
                    textBoxIznajmlj.Text = "";
                    textBoxCena.Text = "";
                    textBoxLokacija.Text = "";
                }
                else if (radioButtonSusK.Checked)
                {
                    SusretiKandidata sk = new SusretiKandidata();

                    sk.naziv = textBoxNaziv.Text;
                    sk.grad = textBoxGrad.Text;

                    sk.lokacija = textBoxLokacija.Text;
                    sk.trajanje = Convert.ToInt32(textBoxTrajanje.Text);

                    s.Save(sk);
                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno ste dodali podatke u bazu.");

                    textBoxLokacija.Text = "";
                    textBoxTrajanje.Text = "";
                }
                textBoxGrad.Text = "";
                textBoxNaziv.Text = "";
                g.RefreshGridLetci();
                g.RefreshGridOtvoreni();
                g.RefreshGridSusreti();
                g.RefreshGridZatvoreni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxLokacija_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                
                textBoxLokacija.Text = "";
            }
        }

        private void radioButtonDeljeLet_CheckedChanged(object sender, EventArgs e)
        {
            labelLokacija.Visible = false;
            textBoxLokacija.Visible = false;
            labelTrajanje.Visible = false;
            textBoxTrajanje.Visible = false;
            labelZatvoren.Visible = false;
            checkBoxZatvoren.Visible = false;
            groupBoxZatvori.Visible = false;
        }

        private void radioButtonSusK_CheckedChanged(object sender, EventArgs e)
        {
            labelLokacija.Visible = true;
            textBoxLokacija.Visible = true;
            labelTrajanje.Visible = true;
            textBoxTrajanje.Visible = true;
            labelZatvoren.Visible = false;
            checkBoxZatvoren.Visible = false;
            groupBoxZatvori.Visible = false;
        }

        private void radioButtonPolM_CheckedChanged(object sender, EventArgs e)
        {
            labelLokacija.Visible = true;
            textBoxLokacija.Visible = true;

            labelTrajanje.Visible = false;
            textBoxTrajanje.Visible = false;
            labelZatvoren.Visible = true;
            checkBoxZatvoren.Visible = true;
            if (checkBoxZatvoren.Checked)
            {
                groupBoxZatvori.Visible = true;
                
            }

        }

        private void checkBoxZatvoren_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxZatvoren.Checked)
            {
                groupBoxZatvori.Visible = true;
            }
            else
            {
                groupBoxZatvori.Visible = false;
            }

        }
    }
}
