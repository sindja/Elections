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
    public partial class Glavna : Form
    {
        Pocetna p;
        string grad = "Beograd";
        public Glavna(Pocetna k)
        {
            InitializeComponent();
            p = k;
            radioButtonSrbija.Checked = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Close();
        }
        public void osveziSve()
        {
            RefreshGridGM();
            RefreshGridLetci();
            RefreshGridOtvoreni();
            RefreshGridZatvoreni();
            RefreshGridSusreti();
            
        }


        //**************************************************************************************************************//
        //                      REKLAME
        //**************************************************************************************************************//

        public void RefreshGridR_TV()
        {
            dataGridViewR_TV.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from R_TV where krajReklamiranja <= ?");
                q.SetDateTime(0, dateTime.Value);

                IList<R_TV> rt = q.List<R_TV>();

                foreach (R_TV r in rt)
                {
                    dataGridViewR_TV.Rows.Add(r.id, r.nazivStanice, r.brojEmitovanja, r.trajanje, r.iznos);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshGridPanoi()
        {
            dataGridViewPanoi.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Panoi where krajReklamiranja <= ?");
                q.SetDateTime(0, dateTime.Value);

                IList<Panoi> pan = q.List<Panoi>();

                foreach (Panoi p in pan)
                {
                    dataGridViewPanoi.Rows.Add(p.id, p.grad, p.adresa, p.nazivAgencije, p.povrsinaPanoa, p.iznos);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshGridStampa()
        {
            dataGridViewStampa.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Stampa where krajReklamiranja <= ?");
                q.SetDateTime(0, dateTime.Value);

                IList<Stampa> sta = q.List<Stampa>();

                foreach (Stampa st in sta)
                {
                    dataGridViewStampa.Rows.Add(st.id, st.nazivLista, st.kolor, st.iznos);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewR_TV.Visible == true)
                {
                    if (dataGridViewR_TV.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewR_TV.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewR_TV.Rows[id];

                        R_TV tmp = s.Load<R_TV>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.nazivStanice = (string)selectedRow.Cells[1].Value;
                        tmp.brojEmitovanja = Convert.ToInt16(selectedRow.Cells[2].Value);
                        tmp.trajanje = Convert.ToInt32(selectedRow.Cells[3].Value);
                        tmp.iznos = Convert.ToInt32(selectedRow.Cells[4].Value);


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridR_TV();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                else if (dataGridViewPanoi.Visible == true)
                {
                    if (dataGridViewPanoi.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPanoi.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPanoi.Rows[id];

                        Panoi tmp = s.Load<Panoi>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.grad = (string)selectedRow.Cells[1].Value;
                        tmp.adresa = (string)selectedRow.Cells[2].Value;
                        tmp.nazivAgencije = (string)selectedRow.Cells[3].Value;
                        tmp.povrsinaPanoa = Convert.ToInt16(selectedRow.Cells[4].Value);
                        tmp.iznos = Convert.ToInt32(selectedRow.Cells[5].Value);


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridPanoi();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                else if (dataGridViewStampa.Visible == true)
                {
                    if (dataGridViewStampa.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewStampa.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewStampa.Rows[id];

                        Stampa tmp = s.Load<Stampa>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.nazivLista = (string)selectedRow.Cells[1].Value;
                        tmp.kolor = (string)selectedRow.Cells[2].Value;
                        tmp.iznos = Convert.ToInt32(selectedRow.Cells[3].Value);


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridStampa();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonR_TV_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewR_TV.Visible = true;
            dataGridViewPanoi.Visible = false;
            dataGridViewStampa.Visible = false;
            btnIzmeni.Visible = true;
            buttonObrisi.Visible = true;

            RefreshGridR_TV();
        }

        private void radioButtonPanoi_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewR_TV.Visible = false;
            dataGridViewStampa.Visible = false;
            dataGridViewPanoi.Visible = true;
            btnIzmeni.Visible = true;
            buttonObrisi.Visible = true;

            RefreshGridPanoi();
        }

        private void radioButtonStampa_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewR_TV.Visible = false;
            dataGridViewPanoi.Visible = false;
            dataGridViewStampa.Visible = true;
            btnIzmeni.Visible = true;
            buttonObrisi.Visible = true;

            RefreshGridStampa();
        }

        private void buttonDodajRP_Click(object sender, EventArgs e)
        {
            UnosReklamniProstor urp = new UnosReklamniProstor(this);
            urp.ShowDialog();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            RefreshGridStampa();
            RefreshGridPanoi();
            RefreshGridR_TV();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewR_TV.Visible == true)
                {
                    if (dataGridViewR_TV.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewR_TV.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewR_TV.Rows[id];

                        R_TV tmp = s.Load<R_TV>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridR_TV();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                else if (dataGridViewPanoi.Visible == true)
                {
                    if (dataGridViewPanoi.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPanoi.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPanoi.Rows[id];

                        Panoi tmp = s.Load<Panoi>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridPanoi();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                else if (dataGridViewStampa.Visible == true)
                {
                    if (dataGridViewStampa.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewStampa.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewStampa.Rows[id];

                        Stampa tmp = s.Load<Stampa>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridStampa();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //**************************************************************************************************************//
        //                      POJAVLJIVANJE
        //**************************************************************************************************************//

        private void btnRTV_Click(object sender, EventArgs e)
        {
            buttonObrisiSve.Visible = true;
            buttonObrisiPkandidata.Visible = false;
            buttonObrisiPitanja.Visible = false;
            buttonObrisiNovinara.Visible = false;

            textBoxImeNovinara.Visible = false;
            btnDodajNovinara.Visible = false;
            btnNovinari.Visible = false;
            dataGridViewRTV.Visible = true;
            dataGridViewIntervjui.Visible = false;
            dataGridViewPitanja.Visible = false;
            dataGridViewNovinari.Visible = false;
            dataGridViewPkandidati.Visible = false;
            btnNovinari.Visible = false;
            btnIzmenaPojavljivanja.Visible = true;
            btnIzmenaPitanja.Visible = false;
            btnIzmeniPkandidata.Visible = false;
            textBoxImeNovinara.Visible = false;
            btnDodajNovinara.Visible = false;
            dataGridViewRTV.Rows.Clear();
            btnIzmeni.Visible = true;
            RefreshGridRTV();
        }

        private void btnIntervjui_Click(object sender, EventArgs e)
        {

            buttonObrisiSve.Visible = true;
            buttonObrisiPkandidata.Visible = false;
            buttonObrisiPitanja.Visible = false;
            buttonObrisiNovinara.Visible = false;

            textBoxImeNovinara.Visible = false;
            btnDodajNovinara.Visible = false;
            dataGridViewPitanja.Visible = false;
            dataGridViewNovinari.Visible = false;
            dataGridViewPkandidati.Visible = false;
            btnNovinari.Visible = true;
            btnIzmenaPojavljivanja.Visible = true;
            btnIzmenaPitanja.Visible = false;
            btnIzmeniPkandidata.Visible = false;

            dataGridViewRTV.Visible = false;
            dataGridViewIntervjui.Visible = true;


            dataGridViewIntervjui.Rows.Clear();
            btnIzmeni.Visible = false;
            dataGridViewNovinari.Visible = false;
            RefreshGridIntervjui();
        }

        private void btnDuel_Click(object sender, EventArgs e)
        {
            btnIzmeni.Visible = false;
            btnIzmenaPojavljivanja.Visible = false;
            buttonObrisiSve.Visible = false;
            buttonObrisiPkandidata.Visible = true;
            buttonObrisiPitanja.Visible = true;
            buttonObrisiNovinara.Visible = false;

            textBoxImeNovinara.Visible = false;
            btnDodajNovinara.Visible = false;
            btnIzmeni.Visible = false;
            dataGridViewPitanja.Visible = true;
            dataGridViewPkandidati.Visible = true;
            btnNovinari.Visible = false;
            dataGridViewRTV.Visible = false;
            dataGridViewIntervjui.Visible = false;
            dataGridViewNovinari.Visible = false;
            btnIzmenaPitanja.Visible = true;
            btnIzmeniPkandidata.Visible = true;

            this.RefreshGridPitanja();
            this.RefreshGridPkandidati();


        }



        //menja zeljene podatke u bazi 
        private void btnIzmenaPojavljivanja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //RTV pojavljivanje
                if (dataGridViewRTV.Visible == true)
                {
                    if (dataGridViewRTV.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewRTV.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewRTV.Rows[id];

                        RTV tmp = s.Load<RTV>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.naziv = (string)selectedRow.Cells[1].Value;
                        tmp.emisija = (string)selectedRow.Cells[2].Value;
                        tmp.voditelj = (string)selectedRow.Cells[3].Value;
                        tmp.gledanost = Convert.ToSingle(selectedRow.Cells[4].Value);//ne radi


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();
                        MessageBox.Show("uspesno izmenjeno!");
                        this.RefreshGridRTV();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                //menja novinara
                else if (dataGridViewNovinari.Visible == true)
                {
                    if (dataGridViewNovinari.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewNovinari.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewNovinari.Rows[id];

                        ImenaNovinara tmp = s.Load<ImenaNovinara>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.imena_novirana = (string)selectedRow.Cells[1].Value;


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridNovinari();
                        MessageBox.Show("Uspesno ste izmenili novinara.");
                    }

                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                //menja intervjue
                else if (dataGridViewIntervjui.Visible == true)
                {

                    if (dataGridViewIntervjui.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewIntervjui.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewIntervjui.Rows[id];

                        IntervjuiStampa tmp = s.Load<IntervjuiStampa>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        tmp.naziv_lista = (string)selectedRow.Cells[1].Value;
                        tmp.datum_intervjua = Convert.ToDateTime(selectedRow.Cells[2].Value);
                        tmp.datum_objavljivanja = Convert.ToDateTime(selectedRow.Cells[3].Value);



                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridIntervjui();
                        MessageBox.Show("Uspesno ste izmenili zeljeni podatak.");
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void RefreshGridRTV()
        {
            dataGridViewRTV.Rows.Clear();
            dataGridViewRTV.Columns[0].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();
                var table = s.QueryOver<RTV>().List();

                foreach (RTV r in table)
                {
                    dataGridViewRTV.Rows.Add(r.id, r.naziv, r.emisija, r.voditelj, r.gledanost);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshGridIntervjui()
        {
            dataGridViewIntervjui.Rows.Clear();
            dataGridViewIntervjui.Columns[0].Visible = false;
            dataGridViewIntervjui.Columns[2].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();
                var table = s.QueryOver<IntervjuiStampa>().List();
                foreach (IntervjuiStampa r in table)
                {
                    dataGridViewIntervjui.Rows.Add(r.id, r.naziv_lista, r.datum_intervjua, r.datum_objavljivanja);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //novinari koji su uradili intervju
        private void btnNovinari_Click(object sender, EventArgs e)
        {
            if (textBoxImeNovinara.Visible)
            {
                buttonObrisiSve.Visible = true;
                buttonObrisiPkandidata.Visible = false;
                buttonObrisiPitanja.Visible = false;

                buttonObrisiNovinara.Visible = false;
                textBoxImeNovinara.Visible = false;
                btnDodajNovinara.Visible = false;
                dataGridViewNovinari.Visible = false;
            }
            else
            {
                buttonObrisiSve.Visible = true;
                buttonObrisiPkandidata.Visible = false;
                buttonObrisiPitanja.Visible = false;

                buttonObrisiNovinara.Visible = true;
                textBoxImeNovinara.Visible = true;
                btnDodajNovinara.Visible = true;
                dataGridViewNovinari.Visible = true;
            }
        }

        private void dataGridViewIntervjui_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridNovinari();
        }

        public void RefreshGridNovinari()
        {
            dataGridViewNovinari.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewIntervjui.SelectedRows.Count == 1)
                {
                    
                    dataGridViewNovinari.Columns[0].Visible = false;

                    int id = Convert.ToInt32(dataGridViewIntervjui.SelectedCells[0].Value);
                    IQuery q = s.CreateQuery("from ImenaNovinara where id_intervjui_stampa = :id");
                    q.SetParameter("id", id);

                    IList<ImenaNovinara> sta = q.List<ImenaNovinara>();
                    
                    foreach (ImenaNovinara st in sta)
                    {
                        dataGridViewNovinari.Rows.Add(st.id_imena_novinara, st.imena_novirana);
                    }
                    s.Close();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu za koju želite da vidite novinare!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RefreshGridPitanja()
        {
            dataGridViewPitanja.Rows.Clear();
            dataGridViewPitanja.Columns[0].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();

               
                var table = s.QueryOver<Pitanja>().List();
                foreach (Pitanja st in table)
                {

                    dataGridViewPitanja.Rows.Add(st.id_pitanja, st.pitanja);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RefreshGridPkandidati()
        {
            dataGridViewPkandidati.Rows.Clear();
            dataGridViewPkandidati.Columns[0].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();


                var table = s.QueryOver<Protivkandidati>().List();
                foreach (Protivkandidati st in table)
                {

                    dataGridViewPkandidati.Rows.Add(st.id_protivkandidati, st.protivkandidati);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmenaPitanja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewPitanja.Visible == true)
                {
                    if (dataGridViewPitanja.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPitanja.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPitanja.Rows[id];

                        Pitanja tmp = s.Load<Pitanja>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        tmp.pitanja = (string)selectedRow.Cells[1].Value;



                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridPitanja();
                        MessageBox.Show("USPESNO STE IZMENILI PITANJE!");
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIzmeniPkandidata_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewPkandidati.Visible == true)
                {
                    if (dataGridViewPkandidati.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPkandidati.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPkandidati.Rows[id];

                        Protivkandidati tmp = s.Load<Protivkandidati>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        tmp.protivkandidati = (string)selectedRow.Cells[1].Value;



                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridPkandidati();
                        MessageBox.Show("Uspesno ste izmenili protivkandidata!");
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajPojavljivanje_Click_1(object sender, EventArgs e)
        {
            UnosPojavljivanja urp = new UnosPojavljivanja(this);
            urp.Show();
        }

        private void btnDodajNovinara_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewIntervjui.Visible == true)
                {
                    if (dataGridViewIntervjui.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewIntervjui.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewIntervjui.Rows[id];

                        IntervjuiStampa tmp = s.Load<IntervjuiStampa>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        ImenaNovinara nov = new ImenaNovinara();
                        nov.id_intervjui_stampa = tmp;
                        nov.imena_novirana = textBoxImeNovinara.Text;

                        s.Save(nov);
                        s.Flush();
                        s.Close();

                        this.RefreshGridNovinari();
                        textBoxImeNovinara.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte novinara!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonObrisiSve_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //brise RTV pojavljivanje
                if (dataGridViewRTV.Visible == true)
                {
                    if (dataGridViewRTV.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewRTV.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewRTV.Rows[id];

                        RTV tmp = s.Load<RTV>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridRTV();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                else if (dataGridViewIntervjui.Visible == true)
                {
                    if (dataGridViewIntervjui.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewIntervjui.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewIntervjui.Rows[id];

                        IntervjuiStampa tmp = s.Load<IntervjuiStampa>(Convert.ToInt32(selectedRow.Cells[0].Value));


                        ISession s2 = DataLayer.GetSession();
                        foreach (ImenaNovinara nov in tmp.novinari)
                        {
                            ImenaNovinara pom = s2.Load<ImenaNovinara>(nov.id_imena_novinara);
                            s2.Delete(pom);

                        }
                        s2.Flush();
                        s2.Close();
                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridIntervjui();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonObrisiNovinara_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewNovinari.SelectedRows.Count == 1)
                {
                    int id = dataGridViewNovinari.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewNovinari.Rows[id];
                    ImenaNovinara tmp = s.Load<ImenaNovinara>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    s.Delete(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridNovinari();
                    MessageBox.Show("Uspesno ste izmenili novinara.");
                }

                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonObrisiPitanja_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewPitanja.Visible == true)
                {
                    if (dataGridViewPitanja.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPitanja.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPitanja.Rows[id];

                        Pitanja tmp = s.Load<Pitanja>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();
                        this.RefreshGridPitanja();


                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonObrisiPkandidata_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewPkandidati.Visible == true)
                {
                    if (dataGridViewPkandidati.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPkandidati.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPkandidati.Rows[id];

                        Protivkandidati tmp = s.Load<Protivkandidati>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();
                        this.RefreshGridPkandidati();

                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //**************************************************************************************************************//
        //                      STRANKA
        //**************************************************************************************************************//

        private void buttonGM_Click(object sender, EventArgs e)
        {
            groupBoxGM.Visible = true;
            groupBoxAktivisti.Visible = false;
            groupBoxAkcije.Visible = false;
        }

        private void radioButtonBeograd_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBeograd.Checked)
            {
                grad = "Beograd";
                osveziSve();
            }
        }

        private void radioButton1NoviSad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1NoviSad.Checked)
            {
                grad = "Novi Sad";
                osveziSve();
            }
        }

        private void radioButtonKragujevac_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKragujevac.Checked)
            {
                grad = "Kragujevac";
                osveziSve();
            }
        }

        private void radioButtonNis_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNis.Checked)
            {
                grad = "Nis";
                osveziSve();
            }
        }

        private void radioButtonSrbija_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSrbija.Checked)
            {
                grad = "Srbija";
                osveziSve();
            }
        }

        private void buttonAktivista_Click(object sender, EventArgs e)
        {
            groupBoxAktivisti.Visible = true;
            groupBoxGM.Visible = false;
            groupBoxAkcije.Visible = false;
        }

        private void buttonAkcija_Click(object sender, EventArgs e)
        {
            groupBoxAktivisti.Visible = false;
            groupBoxGM.Visible = false;
            groupBoxAkcije.Visible = true;
        }

        //*********************************
        //       Glasacko mesto
        //*********************************

        public void RefreshGridGM()
        {
            dataGridViewGM.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q;
                if (grad.Equals("Srbija"))
                {
                    q = s.CreateQuery("from GlasackoMesto");
                }
                else
                {
                    q = s.CreateQuery("from GlasackoMesto where grad = ?");
                    q.SetParameter(0, grad);
                }

                IList<GlasackoMesto> gm = q.List<GlasackoMesto>();

                foreach (GlasackoMesto c in gm)
                {
                    dataGridViewGM.Rows.Add(c.id, c.broj, c.naziv, c.brojBiracaI, c.procenatOsvojenihGlasovaI + "%", c.brojBiracaII, c.procenatOsvojenihGlasovaII + "%");
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObrisiGM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    GlasackoMesto tmp = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    s.Delete(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridGM();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzmeniGM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    GlasackoMesto tmp = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    string[] tx = selectedRow.Cells[4].Value.ToString().Split('%');
                    string[] tx2 = selectedRow.Cells[6].Value.ToString().Split('%');
                    tmp.broj = (int)selectedRow.Cells[1].Value;
                    tmp.naziv = (string)selectedRow.Cells[2].Value;
                    tmp.brojBiracaI = Convert.ToInt32(selectedRow.Cells[3].Value);
                    tmp.procenatOsvojenihGlasovaI = Convert.ToSingle(tx[0]);
                    tmp.brojBiracaII = Convert.ToInt32(selectedRow.Cells[5].Value);
                    tmp.procenatOsvojenihGlasovaII = Convert.ToSingle(tx2[0]);

                    s.SaveOrUpdate(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridGM();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewGM_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridDezura();
            RefreshPrimedbe();
        }

        public void RefreshGridDezura()
        {
            try
            {
                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    ISession s = DataLayer.GetSession();

                    GlasackoMesto g = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    dataGridViewDezura.Rows.Clear();

                    foreach (Aktivista c in g.GlmAktiviste)
                    {
                        dataGridViewDezura.Rows.Add(c.id, c.ime, c.prezime, null);
                    }

                    s.Close();
                    buttonUkloniAk.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Primedbe visevrednosni
        private void buttonPrimedbe_Click(object sender, EventArgs e)
        {
            dataGridViewPrimedbe.Visible = true;
            textBoxDodajPrim.Visible = true;
            labelDodajPrim.Visible = true;
            buttonObrisiPrim.Visible = true;
            dataGridViewPrimedbe.Rows.Clear();
            RefreshPrimedbe();
        }

        public void RefreshPrimedbe()
        {
            dataGridViewPrimedbe.Rows.Clear();
            try
            {
                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    ISession s = DataLayer.GetSession();

                    GlasackoMesto g = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    foreach (Primedbe c in g.primedbe)
                    {
                        dataGridViewPrimedbe.Rows.Add(c.id_primedbe, c.primedbe);
                    }

                    s.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonObrisiPrim_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewPrimedbe.SelectedRows.Count == 1)
                {
                    int id = dataGridViewPrimedbe.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewPrimedbe.Rows[id];

                    Primedbe tmp = s.Load<Primedbe>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    s.Delete(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshPrimedbe();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxDodajPrim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    if (dataGridViewGM.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewGM.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                        GlasackoMesto tmp = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        Primedbe prim = new Primedbe();
                        prim.primedbe = textBoxDodajPrim.Text;
                        tmp.primedbe.Add(prim);

                        s.Save(prim);
                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshPrimedbe();
                        textBoxDodajPrim.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        //dodeli aktivistu na glasacko mesto
        private void buttonDodeliAkti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                var table = s.QueryOver<Aktivista>().List();
                foreach (Aktivista ak in table)
                {
                    dataGridViewDezura.Rows.Add(ak.id, ak.ime, ak.prezime);
                }

                s.Close();
                buttonUkloniAk.Visible = false;
                buttonDodajAkGM.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDodajAkGM_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    GlasackoMesto tmp = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    id = dataGridViewDezura.SelectedCells[0].RowIndex;
                    selectedRow = dataGridViewDezura.Rows[id];
                    Aktivista ak = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));


                    tmp.GlmAktiviste.Add(ak);

                    s.SaveOrUpdate(ak);
                    s.SaveOrUpdate(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridDezura();
                    buttonDodajAkGM.Visible = false;
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUkloniAk_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewGM.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGM.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGM.Rows[id];

                    GlasackoMesto tmp = s.Load<GlasackoMesto>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    id = dataGridViewDezura.SelectedCells[0].RowIndex;
                    selectedRow = dataGridViewDezura.Rows[id];
                    Aktivista ak = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));


                    tmp.GlmAktiviste.Remove(ak);

                    s.SaveOrUpdate(ak);
                    s.SaveOrUpdate(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridDezura();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*********************************
        //       Akcije
        //*********************************

        private void buttonDodAkc_Click(object sender, EventArgs e)
        {
            DodajAkciju d = new DodajAkciju(this);
            d.ShowDialog();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxSusretiK.Visible = false;
            groupBoxMitinzi.Visible = false;
            groupBoxDeljenjeLet.Visible = true;
            RefreshGridLetci();
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxSusretiK.Visible = true;
            groupBoxMitinzi.Visible = false;
            groupBoxDeljenjeLet.Visible = false;
            RefreshGridSusreti();
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBoxSusretiK.Visible = false;
            groupBoxMitinzi.Visible = true;
            groupBoxDeljenjeLet.Visible = false;
            RefreshGridOtvoreni();
            RefreshGridZatvoreni();
        }


        private void buttonIzmeniSus_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewSusreti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewSusreti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewSusreti.Rows[id];

                    SusretiKandidata tmp = s.Load<SusretiKandidata>(Convert.ToInt32(selectedRow.Cells[0].Value));


                    tmp.naziv = (string)selectedRow.Cells[1].Value;
                    tmp.trajanje = Convert.ToInt32(selectedRow.Cells[2].Value);
                    tmp.lokacija = (string)selectedRow.Cells[3].Value;

                    s.SaveOrUpdate(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridSusreti();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonObrisiSus_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewSusreti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewSusreti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewSusreti.Rows[id];

                    SusretiKandidata tmp = s.Load<SusretiKandidata>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    s.Delete(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridSusreti();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void buttonIzmeniMitinzi_Click(object sender, EventArgs e)
        {
            if (radioButtonZatvoren.Checked)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    if (dataGridViewZatvoreni.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewZatvoreni.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewZatvoreni.Rows[id];

                        ZatvoreniMiting tmp = s.Load<ZatvoreniMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        tmp.naziv=(string)(selectedRow.Cells[1].Value);
                        tmp.iznajmljivac=(string)(selectedRow.Cells[2].Value);
                        tmp.cena_iznajmljivanja=Convert.ToInt32(selectedRow.Cells[3].Value);
                        tmp.lokacija = (string)(selectedRow.Cells[4].Value);
                       
                        s.Update(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridZatvoreni();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da izmenite!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButtonOtvoren.Checked)
            {

                try
                {
                    ISession s = DataLayer.GetSession();
                    if (dataGridViewPoliticki.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPoliticki.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPoliticki.Rows[id];

                        PolitickiMiting tmp = s.Load<PolitickiMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.naziv = (string)(selectedRow.Cells[1].Value);
                        tmp.lokacija = (string)(selectedRow.Cells[2].Value);

                        s.Update(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridOtvoreni();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da izmenite!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void buttonObrisiMitinzi_Click(object sender, EventArgs e)
        {
            if (radioButtonZatvoren.Checked)
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    if (dataGridViewZatvoreni.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewZatvoreni.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewZatvoreni.Rows[id];

                        ZatvoreniMiting tmp = s.Load<ZatvoreniMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridZatvoreni();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (radioButtonOtvoren.Checked)
            {

                try
                {
                    ISession s = DataLayer.GetSession();
                    if (dataGridViewPoliticki.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewPoliticki.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewPoliticki.Rows[id];

                        PolitickiMiting tmp = s.Load<PolitickiMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridOtvoreni();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void buttonDodajGosta_Click(object sender, EventArgs e)
        {
             try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewGosti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGosti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGosti.Rows[id];

                    Gost tmp = new Gost();
                    if (dataGridViewPoliticki.SelectedRows.Count == 1)
                    {
                        int idp = dataGridViewPoliticki.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRowp = dataGridViewPoliticki.Rows[idp];
                        PolitickiMiting pm = s.Load<PolitickiMiting>(Convert.ToInt32(selectedRowp.Cells[0].Value));
                        tmp.PrisustvujeN = pm;
                    }

                    else if (dataGridViewZatvoreni.SelectedRows.Count == 1)
                    {
                        int idz = dataGridViewZatvoreni.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRowz = dataGridViewZatvoreni.Rows[idz];
                        ZatvoreniMiting z = s.Load<ZatvoreniMiting>(Convert.ToInt32(selectedRowz.Cells[0].Value));
                        tmp.PrisustvujeN = z;
                    }

                    tmp.ime = (string)selectedRow.Cells[1].Value;
                    tmp.prezime = (string)(selectedRow.Cells[2].Value);
                    tmp.funkcija = (string)selectedRow.Cells[3].Value;
                    tmp.titula = (string)selectedRow.Cells[4].Value;
                    s.Save(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridGosti();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju ste uneli!");
                }
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

        }

        private void buttonIzmeniGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewGosti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGosti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGosti.Rows[id];

                    Gost tmp = s.Load<Gost>(Convert.ToInt32(selectedRow.Cells[0].Value));


                    tmp.ime = (string)selectedRow.Cells[1].Value;
                    tmp.prezime = (string)(selectedRow.Cells[2].Value);
                    tmp.funkcija = (string)selectedRow.Cells[3].Value;
                    tmp.titula = (string)selectedRow.Cells[4].Value;
                    s.SaveOrUpdate(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridGosti();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObrisiGost_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewGosti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewGosti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewGosti.Rows[id];

                    Gost tmp = s.Load<Gost>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    s.Delete(tmp);
                    s.Flush();
                    s.Close();

                    this.RefreshGridGosti();
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu koju želite da obrišete!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonZatvoren_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonZatvoren.Checked == true)
            {
                RefreshGridZatvoreni();
                dataGridViewZatvoreni.Show();
                dataGridViewPoliticki.Hide();
            }
            else
                RefreshGridZatvoreni();
        }

        private void radioButtonOtvoren_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOtvoren.Checked == true)
            {
                RefreshGridOtvoreni();
                dataGridViewZatvoreni.Hide();
                dataGridViewPoliticki.Show();
            }
            else
                RefreshGridOtvoreni();
        }
        public void RefreshGridSusreti()
        {
            dataGridViewSusreti.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q;
                if (grad.Equals("Srbija"))
                {
                    q = s.CreateQuery("from SusretiKandidata");
                }
                else
                {
                    q = s.CreateQuery("from SusretiKandidata where grad = ?");
                    q.SetParameter(0, grad);
                }
                IList<SusretiKandidata> srt = q.List<SusretiKandidata>();

                foreach (SusretiKandidata r in srt)
                {
                    dataGridViewSusreti.Rows.Add(r.id, r.naziv, r.trajanje, r.lokacija);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void RefreshGridZatvoreni()
        {

            dataGridViewZatvoreni.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q;
                if (grad.Equals("Srbija"))
                {
                    q = s.CreateQuery("from ZatvoreniMiting");
                }
                else
                {
                    q = s.CreateQuery("from ZatvoreniMiting where grad = ?");
                    q.SetParameter(0, grad);
                }


                IList<ZatvoreniMiting> zm = q.List<ZatvoreniMiting>();

                foreach (ZatvoreniMiting r in zm)
                {
                    dataGridViewZatvoreni.Rows.Add(r.id, r.naziv, r.iznajmljivac, r.cena_iznajmljivanja, r.lokacija);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void RefreshGridOtvoreni()
        {

            dataGridViewPoliticki.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q;
                if (grad.Equals("Srbija"))
                {
                    q = s.CreateQuery("from PolitickiMiting");
                }
                else
                {
                    q = s.CreateQuery("from PolitickiMiting where grad = ?");
                    q.SetParameter(0, grad);
                }

                IList<PolitickiMiting> zm = q.List<PolitickiMiting>();

                foreach (PolitickiMiting r in zm)
                {
                    dataGridViewPoliticki.Rows.Add(r.id, r.naziv, r.lokacija);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dataGridViewZatvoreni_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridGosti();
        }

        public void RefreshGridGosti()
        {
            try
            {
                if (dataGridViewZatvoreni.SelectedRows.Count == 1)
                {
                    int id = dataGridViewZatvoreni.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewZatvoreni.Rows[id];

                    ISession s = DataLayer.GetSession();

                    ZatvoreniMiting g = s.Load<ZatvoreniMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    dataGridViewGosti.Rows.Clear();

                    foreach (Gost c in g.Prisustvuje)
                    {
                        dataGridViewGosti.Rows.Add(c.id, c.ime, c.prezime, c.funkcija, c.titula);
                    }

                    s.Close();
                }
                else if (dataGridViewPoliticki.SelectedRows.Count == 1)
                {
                    int id = dataGridViewPoliticki.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewPoliticki.Rows[id];

                    ISession s = DataLayer.GetSession();

                    PolitickiMiting g = s.Load<PolitickiMiting>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    dataGridViewGosti.Rows.Clear();

                    foreach (Gost c in g.Prisustvuje)
                    {
                        dataGridViewGosti.Rows.Add(c.id, c.ime, c.prezime, c.funkcija, c.titula);
                    }

                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void dataGridViewPoliticki_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridGosti();
        }

        private void buttonDodajLoka_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            try
            {
                if (dataGridViewDelje.SelectedRows.Count == 1)
                {
                    int id = dataGridViewDelje.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewDelje.Rows[id];
                    DeljenjeLetaka g = s.Load<DeljenjeLetaka>(Convert.ToInt32(selectedRow.Cells[0].Value));
                    Lokacije l = new Lokacije();
                    l.lokacije = textBoxLoka.Text;
                    l.id_deljenje_letaka = g;
                    g.lokacija.Add(l);
                    s.Save(l);
                    s.Update(g);
                    s.Flush();
                    s.Close();

                    textBoxLoka.Text = "";
                    RefreshGridLetci();
                    RefreshLokacije();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void RefreshGridLetci()
        {
            dataGridViewDelje.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q;
                if (grad.Equals("Srbija"))
                {
                    q = s.CreateQuery("from DeljenjeLetaka");
                }
                else
                {
                    q = s.CreateQuery("from DeljenjeLetaka where grad = ?");
                    q.SetParameter(0, grad);
                }


                IList<DeljenjeLetaka> rt = q.List<DeljenjeLetaka>();

                foreach (DeljenjeLetaka r in rt)
                {
                    dataGridViewDelje.Rows.Add(r.id, r.naziv);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void RefreshLokacije()
        {
            listBoxDeljenjeLet.Items.Clear();
            int id = dataGridViewDelje.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridViewDelje.Rows[id];

            ISession s = DataLayer.GetSession();
            try
            {
                DeljenjeLetaka g = s.Load<DeljenjeLetaka>(Convert.ToInt32(selectedRow.Cells[0].Value));

                foreach (Lokacije c in g.lokacija)
                {
                    listBoxDeljenjeLet.Items.Add(c.lokacije);
                }
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDelje_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshLokacije();
        }

        //*********************************
        //       Aktivista
        //*********************************


        private void buttonDodajAkt_Click(object sender, EventArgs e)
        {
            AktivistaUnos ak = new AktivistaUnos(this);
            ak.ShowDialog();
        }

        public void RefreshGridAktivisti()
        {
            dataGridViewAktivisti.Rows.Clear();
            dataGridViewAktivisti.Visible = true;
            dataGridViewAktivisti.Columns[0].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();


                var table = s.QueryOver<Aktivista>().List();
                foreach (Aktivista ak in table)
                {
                    dataGridViewAktivisti.Rows.Add(ak.id, ak.ime, ak.imeRoditelja, ak.prezime, ak.datumRodjenja, ak.adresa);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonAkt_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGridAktivisti();
            dataGridViewKoordinator.Visible = false;
            buttonIzmeniAkKo.Visible = true;
            buttonObrisiAkKo.Visible = true;
            buttonAkcije.Visible = true;
            listBoxPomocnici.Visible = false;
            buttonPomocnici.Visible = false;
            buttonIzaberiAkt.Visible = false;
            buttonPotvrdiAktuKoo.Visible = false;
            labelIzaberi.Visible = false;
            buttonEma.Visible = true;
            buttonBr.Visible = true;
            listBoxEma.Visible = false;
            listBoxBr.Visible = false;
            listBoxAkcije.Visible = false;

        }

        public void RefreshGridKoordinator()
        {
            dataGridViewKoordinator.Rows.Clear();
            dataGridViewKoordinator.Visible = true;
            dataGridViewKoordinator.Columns[0].Visible = false;
            try
            {
                ISession s = DataLayer.GetSession();


                var table = s.QueryOver<Koordinator>().List();
                foreach (Koordinator koo in table)
                {
                    dataGridViewKoordinator.Rows.Add(koo.id, koo.ime, koo.prezime, koo.imeOpstine, koo.adresaKancelarije);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonKoor_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGridKoordinator();
            dataGridViewAktivisti.Visible = false;
            buttonIzmeniAkKo.Visible = true;
            buttonObrisiAkKo.Visible = true;
            buttonAkcije.Visible = false;
            listBoxAkcije.Visible = false;
            listBoxPomocnici.Visible = false;
            buttonPomocnici.Visible = true;
            buttonIzaberiAkt.Visible = true;
            buttonPotvrdiAktuKoo.Visible = true;
            labelIzaberi.Visible = false;
            buttonEma.Visible = false;
            buttonBr.Visible = false;
            listBoxEma.Visible = false;
            listBoxBr.Visible = false;
        }

        private void buttonIzmeniAkKo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewKoordinator.Visible == true)
                {
                    if (dataGridViewKoordinator.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewKoordinator.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewKoordinator.Rows[id];

                        Koordinator tmp = s.Load<Koordinator>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.ime = (string)selectedRow.Cells[1].Value;
                        tmp.prezime = (string)selectedRow.Cells[2].Value;
                        tmp.imeOpstine = (string)selectedRow.Cells[3].Value;
                        tmp.adresaKancelarije = (string)selectedRow.Cells[4].Value;


                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridKoordinator();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                else if (dataGridViewAktivisti.Visible == true)
                {
                    if (dataGridViewAktivisti.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewAktivisti.Rows[id];

                        Aktivista tmp = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));

                        tmp.ime = (string)selectedRow.Cells[1].Value;
                        tmp.imeRoditelja = (string)selectedRow.Cells[2].Value;
                        tmp.prezime = (string)selectedRow.Cells[3].Value;
                        tmp.datumRodjenja = Convert.ToDateTime(selectedRow.Cells[4].Value);
                        tmp.adresa = (string)selectedRow.Cells[5].Value;

                        s.SaveOrUpdate(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridAktivisti();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObrisiAkKo_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                if (dataGridViewKoordinator.Visible == true)
                {
                    if (dataGridViewKoordinator.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewKoordinator.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewKoordinator.Rows[id];

                        Koordinator tmp = s.Load<Koordinator>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        
                        foreach (Aktivista a in tmp.Pomocnici)
                        {
                            a.Nadredjen = null;
                            s.SaveOrUpdate(a);
                        }
                       
                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridKoordinator();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
                else if (dataGridViewAktivisti.Visible == true)
                {
                    if (dataGridViewAktivisti.SelectedRows.Count == 1)
                    {
                        int id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridViewAktivisti.Rows[id];

                        Aktivista tmp = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));
                        ISession s2 = DataLayer.GetSession();
                        foreach (Email nov in tmp.email)
                        {
                            Email pom = s2.Load<Email>(nov.id_email);
                            s2.Delete(pom);

                        }
                        foreach (BrojeviTelefona nov in tmp.brojevi)
                        {
                            BrojeviTelefona pom = s2.Load<BrojeviTelefona>(nov.id_brojevi_telefona);
                            s2.Delete(pom);

                        }
                        foreach (Akcije nov in tmp.akcije)
                        {
                            Akcije pom = s2.Load<Akcije>(nov.id);
                            s2.Delete(pom);

                        }
                        if (tmp.Nadredjen != null)
                        {
                            tmp.Nadredjen.Pomocnici.Remove(tmp);
                        }
                        s2.Flush();
                        s2.Close();

                        s.Delete(tmp);
                        s.Flush();
                        s.Close();

                        this.RefreshGridAktivisti();
                    }
                    else
                    {
                        MessageBox.Show("Prvo selektujte vrstu koju ste izmenili!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RefreshAkTAkcije()
        {
            listBoxAkcije.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewAktivisti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewAktivisti.Rows[id];

                    Aktivista tmp = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    foreach (Akcije a in tmp.akcije)
                    {
                        listBoxAkcije.Items.Add(a.naziv);
                    }
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAkcije_Click(object sender, EventArgs e)
        {
            if (listBoxAkcije.Visible)
                listBoxAkcije.Visible = false;
            else
                listBoxAkcije.Visible = true;
        }

        private void RefreshPomocnici()
        {
            listBoxPomocnici.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewKoordinator.SelectedRows.Count == 1)
                {
                    int id = dataGridViewKoordinator.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewKoordinator.Rows[id];

                    Koordinator tmp = s.Load<Koordinator>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    foreach (Aktivista a in tmp.Pomocnici)
                    {

                        listBoxPomocnici.Items.Add(a.ime + " " + a.prezime);
                    }
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPomocnici_Click(object sender, EventArgs e)
        {
            RefreshPomocnici();
            if(listBoxPomocnici.Visible)
                listBoxPomocnici.Visible = false;
            else
                listBoxPomocnici.Visible = true;
        }

        private void buttonIzaberiAkt_Click(object sender, EventArgs e)
        {
            dataGridViewKoordinator.Visible = false;
            dataGridViewAktivisti.Visible = true;
            labelIzaberi.Visible = true;
            buttonPotvrdiAktuKoo.Visible = true;
            this.RefreshGridAktivisti();
        }

        private void buttonPotvrdiAktuKoo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewKoordinator.SelectedRows.Count == 1)
                {
                    int id = dataGridViewKoordinator.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewKoordinator.Rows[id];

                    Koordinator tmp = s.Load<Koordinator>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                    selectedRow = dataGridViewAktivisti.Rows[id];
                    Aktivista ak = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));


                    tmp.Pomocnici.Add(ak);
                    ak.Nadredjen = tmp;
              
                    s.SaveOrUpdate(tmp);
                    s.SaveOrUpdate(ak);
                    
                    s.Flush();
                    s.Close();

                    this.RefreshGridAktivisti();
                    this.RefreshGridKoordinator();
                    dataGridViewKoordinator.Visible = true;
                    dataGridViewAktivisti.Visible = false;
                    buttonIzaberiAkt.Visible = true;
                    labelIzaberi.Visible = false;
                    buttonPotvrdiAktuKoo.Visible = false;
                    MessageBox.Show("Dodali ste pomoćnika " + ak.ime + " " + ak.prezime + " " + "koordinatoru "
                                            + tmp.ime + " " + tmp.prezime + ".");
                }
                else
                {
                    MessageBox.Show("Prvo selektujte vrstu kojoj želite da dodate pomoćnika!");
                    dataGridViewKoordinator.Visible = true;
                    dataGridViewAktivisti.Visible = false;
                    labelIzaberi.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void RefreshEmail()
        {
            listBoxEma.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewAktivisti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewAktivisti.Rows[id];

                    Aktivista tmp = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    foreach (Email a in tmp.email)
                    {
                        listBoxEma.Items.Add(a.email);
                    }
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEma_Click(object sender, EventArgs e)
        {
            if(listBoxEma.Visible)
                listBoxEma.Visible = false;
            else
                listBoxEma.Visible = true;
            listBoxBr.Visible = false;
        }

        private void RefreshBrojTelefona()
        {
            listBoxBr.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                if (dataGridViewAktivisti.SelectedRows.Count == 1)
                {
                    int id = dataGridViewAktivisti.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridViewAktivisti.Rows[id];

                    Aktivista tmp = s.Load<Aktivista>(Convert.ToInt32(selectedRow.Cells[0].Value));

                    foreach (BrojeviTelefona a in tmp.brojevi)
                    {
                        listBoxBr.Items.Add(a.brojevi_telefona);
                    }
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBr_Click(object sender, EventArgs e)
        {
            if (listBoxBr.Visible)
                listBoxBr.Visible = false;
            else
                listBoxBr.Visible = true;
            listBoxEma.Visible = false;
        }

        public void dataGridViewZatvoreni_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridGosti();
        }

        private void dataGridViewPoliticki_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshGridGosti();
        }
        private void dataGridViewKoordinator_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshPomocnici();
        }

        private void dataGridViewAktivisti_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RefreshEmail();
            RefreshBrojTelefona();
            RefreshAkTAkcije();
        }


    }
}


