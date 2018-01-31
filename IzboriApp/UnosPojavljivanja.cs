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
    public partial class UnosPojavljivanja : Form
    {
        Glavna g;
        public UnosPojavljivanja(Glavna s)
        {   
            
            InitializeComponent();
            g = s;
        }

        private void btnAddIntervjui_Click(object sender, EventArgs e)
        {
            btnAddIntervjui.Visible = true;
            btnAddDuel.Visible = true;
            btnAddRTV.Visible = true;
            btnOdustani.Visible = true;
            btnIntervjuiPotvrda.Visible = true;
            labelNaziv.Visible = false;
            labelNazivLista.Visible = true;
            textBoxNazivLista.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            labelDatumIntervjua.Visible = true;
            labelDatumObjave.Visible = true;
            labelDatumIntervjua.Visible = true;

            btnIntervjuiPotvrda.Visible = true;
            labelNazivLista.Visible = true;
            labelImeVoditelja.Visible = false;
            labelEmisija.Visible = false;
            labelGledanost.Visible = false;
            textBoxEmisija.Visible = false;
            textBoxImeVoditelja.Visible = false;
            textBoxNaziv.Visible = false;
            textBoxGledanost.Visible = false;
            btnRTVPotvrda.Visible = false;
            btnPotvrdaDuel.Visible = false;

            btnAddPitanje.Visible = false;
            btnAddPk.Visible = false;
            textBoxPkandidat.Visible = false;
            textBoxPitanje.Visible = false;
            listBoxPitanja.Visible = false;
            listBoxPkandidati.Visible = false;
        }

        private void btnAddRTV_Click(object sender, EventArgs e)
        {
            btnAddIntervjui.Visible = true;
            btnAddDuel.Visible = true;
            btnAddRTV.Visible = true;
            btnOdustani.Visible = true;
            btnIntervjuiPotvrda.Visible = false;
            labelNazivLista.Visible = false;

            textBoxNazivLista.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            labelDatumIntervjua.Visible = false;
            labelDatumObjave.Visible = false;
            labelDatumIntervjua.Visible = false;

            btnIntervjuiPotvrda.Visible = false;
            labelNaziv.Visible = true;
            labelImeVoditelja.Visible = true;
            labelEmisija.Visible = true;
            labelGledanost.Visible = true;
            textBoxEmisija.Visible = true;
            textBoxImeVoditelja.Visible = true;
            textBoxNaziv.Visible = true;
            textBoxGledanost.Visible = true;
            btnRTVPotvrda.Visible = true;
            btnPotvrdaDuel.Visible = false;

            btnAddPitanje.Visible = false;
            btnAddPk.Visible = false;
            textBoxPkandidat.Visible = false;
            textBoxPitanje.Visible = false;
            listBoxPitanja.Visible = false;
            listBoxPkandidati.Visible = false;
        }

        private void btnIntervjuiPotvrda_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                 IntervjuiStampa nov=new IntervjuiStampa();
                 nov.naziv_lista = textBoxNazivLista.Text;
                 nov.datum_intervjua = dateTimePicker1.Value;
                 nov.datum_objavljivanja = dateTimePicker2.Value;
                
                s.Save(nov);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali Intervju.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRTVPotvrda_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                RTV nov = new RTV();

                nov.naziv = textBoxNaziv.Text;
                nov.emisija = textBoxEmisija.Text;
                nov.voditelj = textBoxImeVoditelja.Text;
                nov.gledanost = Convert.ToSingle(textBoxGledanost.Text);

                s.Save(nov);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali podatke u bazu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddDuel_Click(object sender, EventArgs e)
        {
            btnAddIntervjui.Visible = true;
            btnAddDuel.Visible = true;
            btnAddRTV.Visible = true;
            btnOdustani.Visible = false;
            btnIntervjuiPotvrda.Visible = false;
            labelNaziv.Visible = false;
            labelNazivLista.Visible = false;
            textBoxNazivLista.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            labelDatumIntervjua.Visible = false;
            labelDatumObjave.Visible = false;
            labelDatumIntervjua.Visible = false;

            btnIntervjuiPotvrda.Visible = false;
            labelNazivLista.Visible = false;
            labelImeVoditelja.Visible = false;
            labelEmisija.Visible = false;
            labelGledanost.Visible = false;
            textBoxEmisija.Visible = false;
            textBoxImeVoditelja.Visible = false;
            textBoxNaziv.Visible = false;
            textBoxGledanost.Visible = false;
            btnRTVPotvrda.Visible = false;
            btnPotvrdaDuel.Visible = true;

            btnAddPitanje.Visible = true;
            btnAddPk.Visible = true;
            textBoxPkandidat.Visible = true;
            textBoxPitanje.Visible = true;
            listBoxPitanja.Visible = true;
            listBoxPkandidati.Visible = true;
            btnOdustani.Visible = true ;
            
        }

        private void btnAddPitanje_Click(object sender, EventArgs e)
        {
            listBoxPitanja.Items.Add(textBoxPitanje.Text);
        }

        private void btnAddPk_Click(object sender, EventArgs e)
        {
            listBoxPkandidati.Items.Add(textBoxPkandidat.Text);
        }

        private void btnPotvrdaDuel_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Duel duel=new Duel();
                //s.Save(duel);
                foreach (string q in listBoxPitanja.Items)
                {
                    Pitanja p = new Pitanja();
                    p.pitanja = q;
                    duel.pitanja.Add(p);
                    s.Save(p);
                    
                    
                }
            

                foreach (string q in listBoxPkandidati.Items)
                {
                    Protivkandidati p = new Protivkandidati();
                    p.protivkandidati = q;
                  
                    duel.pkandidati.Add(p);
                    s.Save(p);
                    
                }
    
                s.Save(duel);
                s.Flush();
                s.Close();
                MessageBox.Show("Uspesno ste dodali Duel zajedno sa pitanjima i protivkanidatima.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        
    }
}
