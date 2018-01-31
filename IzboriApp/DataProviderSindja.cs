using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IzboriApp.Entiteti;
using NHibernate;
using NHibernate.Linq;
using System.Runtime.Serialization;

namespace IzboriApp
{
    //Sindjo sve sto radis vezano za DataProvider ovde kucaj
    public partial class DataProvider
    {
        //Glasacko Mesto


        public IEnumerable<GlasackoMesto> GetGlasackoMesto()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<GlasackoMesto> glasMesto = s.Query<GlasackoMesto>().Where(x => x.id > 0).Select(p => p);

            foreach (GlasackoMesto g in glasMesto)
            {
                g.GlmAktiviste = null;
                g.primedbe = null;

            }
            return glasMesto;
        }
        public GlasackoMesto GetGlasackoMesto(int id)
        {
            ISession s = DataLayer.GetSession();

            GlasackoMesto glasMesto = s.Query<GlasackoMesto>().Where(x => x.id == id).Select(p => p).FirstOrDefault();


            glasMesto.GlmAktiviste = null;
            glasMesto.primedbe = null;

            return glasMesto;
        }
        public int AddGlasackoMesto(GlasackoMesto glasMesto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(glasMesto);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateGlasackoMesto(GlasackoMesto glasMesto)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(glasMesto);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int RemoveGlasackoMesto(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GlasackoMesto glasMesto = s.Load<GlasackoMesto>(id);
                s.Delete(glasMesto);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        //koordinator
        public IEnumerable<Koordinator> GetKoordinatori()
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<Koordinator> kor = s.Query<Koordinator>().Where(x => x.id > 0).Select(p => p);
            IList<Koordinator> akt = new List<Koordinator>();
            foreach (Koordinator ak in kor)
            {
                Koordinator novi = new Koordinator();
                novi.id = ak.id;
                novi.ime = ak.ime;
                novi.imeRoditelja = ak.imeRoditelja;
                novi.prezime = ak.prezime;
                novi.datumRodjenja = ak.datumRodjenja;
                novi.adresa = ak.adresa;
                novi.email = null;
                novi.brojevi = null;
                novi.akcije = null;
                novi.Dezura = null;
                novi.Nadredjen = null;
                novi.imeOpstine = ak.imeOpstine;
                novi.adresaKancelarije = ak.adresaKancelarije;
                //ak = (Aktivista)s.GetSessionImplementation().PersistenceContext.Unproxy(ak);
                akt.Add(novi);
            }
            kor = akt;
            return kor;
        }
        public Koordinator GetKoordinatori(int id)
        {
            ISession s = DataLayer.GetSession();

            Koordinator kor = s.Query<Koordinator>().Where(x => x.id == id).Select(ak => ak).FirstOrDefault();

            if (kor.Pomocnici != null)
            {
                foreach (Aktivista a in kor.Pomocnici)
                {
                    a.brojevi = null;
                    a.email = null;
                    a.Dezura = null;
                    a.akcije = null;
                    a.Nadredjen = null;
                }
            }
            kor.Pomocnici = null;
            kor = (Koordinator)s.GetSessionImplementation().PersistenceContext.Unproxy(kor);

            return kor;
        }

        public int AddKoordinator(Koordinator kor)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(kor);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int RemoveKoordinator(int kor)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Koordinator k = s.Load<Koordinator>(kor);
                s.Delete(k);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
        public int UpdateKoordinator(Koordinator kor)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(kor);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //susreti kandidata

        public IEnumerable<SusretiKandidata> GetSusrete()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<SusretiKandidata> sus = s.Query<SusretiKandidata>().Select(p => p);

            return sus;
        }
        public SusretiKandidata GetSusrete(int id)
        {
            ISession s = DataLayer.GetSession();
            SusretiKandidata sus = s.Query<SusretiKandidata>().Where(x => x.id == id).Select(p => p).FirstOrDefault();
            return sus;
        }

        public int AddSusret(SusretiKandidata sus)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(sus);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveSusret(SusretiKandidata sus)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(sus);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateSusret(SusretiKandidata sus)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(sus);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //politicki miting
        public IEnumerable<PolitickiMiting> GetPolitickiM()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<PolitickiMiting> pm = s.Query<PolitickiMiting>().Select(p => p);
            foreach (PolitickiMiting p in pm)
            {
                p.aktiviste = null;
                p.Prisustvuje = null;

            }
            return pm;
        }
        public PolitickiMiting GetPolitickiM(int id)
        {
            ISession s = DataLayer.GetSession();

            PolitickiMiting pm = s.Query<PolitickiMiting>().Where(x => x.id == id).Select(p => p).FirstOrDefault();
            pm.aktiviste = null;
            pm.Prisustvuje = null;
            return pm;
        }
        public int AddPolitickiM(PolitickiMiting pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemovePolitickiM(PolitickiMiting pano)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Delete(pano);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdatePolitickiM(PolitickiMiting pano)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(pano);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //zatvoreni miting

        public IEnumerable<ZatvoreniMiting> GetZatvoreniM()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ZatvoreniMiting> pm = s.Query<ZatvoreniMiting>().Select(p => p);
            foreach (ZatvoreniMiting p in pm)
            {
                p.aktiviste = null;
                p.Prisustvuje = null;

            }
            return pm;
        }
        public ZatvoreniMiting GetZatvoreniM(int id)
        {
            ISession s = DataLayer.GetSession();

            ZatvoreniMiting pm = s.Query<ZatvoreniMiting>().Where(x => x.id == id).Select(p => p).FirstOrDefault();

            pm.aktiviste = null;
            pm.Prisustvuje = null;
            return pm;
        }

        public int AddZatvoreniM(ZatvoreniMiting pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveZatvoreniM(ZatvoreniMiting pano)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Delete(pano);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateZatvoreniM(ZatvoreniMiting pano)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(pano);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //gost
        public IEnumerable<Gost> GetGost()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Gost> pm = s.Query<Gost>().Select(p => p);
            foreach (Gost p in pm)
            {
                p.PrisustvujeN = null;

            }
            return pm;
        }
        public Gost GetGost(int id)
        {
            ISession s = DataLayer.GetSession();

            Gost pm = s.Query<Gost>().Where(x => x.id == id).Select(p => p).FirstOrDefault();

            pm.PrisustvujeN = null;


            return pm;
        }

        public int AddGost(Gost pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveGost(Gost g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Delete(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateGost(Gost g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        //primedbe visevrednosni 
        public IEnumerable<Primedbe> GetPrimedbe()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Primedbe> pm = s.Query<Primedbe>().Select(p => p);
            foreach (Primedbe p in pm)
            {
                p.id_glasacko_mesto = null;

            }
            return pm;
        }

        public Primedbe GetPrimedbe(int id)
        {
            ISession s = DataLayer.GetSession();

            Primedbe pm = s.Query<Primedbe>().Where(x => x.id_primedbe == id).Select(p => p).FirstOrDefault();

            pm.id_glasacko_mesto = null;

            return pm;
        }

        public int AddPrimedbe(Primedbe pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                GlasackoMesto mesto = s.Load<GlasackoMesto>(80);
                mesto.primedbe.Add(pan);
                pan.id_glasacko_mesto = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemovePrimedbe(Primedbe g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                GlasackoMesto mesto = sa.Load<GlasackoMesto>(80);

                mesto.primedbe.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdatePrimedbe(int id, Primedbe g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_glasacko_mesto = s.Load<GlasackoMesto>(id);
                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //lokacije visevrednosni
        public IEnumerable<Lokacije> GetLokacije()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Lokacije> pm = s.Query<Lokacije>().Select(p => p);
            foreach (Lokacije p in pm)
            {
                p.id_deljenje_letaka = null;

            }
            return pm;
        }
        public Lokacije GetLokacije(int id)
        {
            ISession s = DataLayer.GetSession();

            Lokacije pm = s.Query<Lokacije>().Where(x => x.id_lokacije == id).Select(p => p).FirstOrDefault();

            pm.id_deljenje_letaka = null;

            return pm;
        }

        public int AddLokacije(Lokacije pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                DeljenjeLetaka mesto = s.Load<DeljenjeLetaka>(125);
                mesto.lokacija.Add(pan);
                pan.id_deljenje_letaka = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveLokacije(Lokacije g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                DeljenjeLetaka mesto = sa.Load<DeljenjeLetaka>(125);

                mesto.lokacija.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateLokacije(int id, Lokacije g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_deljenje_letaka = s.Load<DeljenjeLetaka>(id);
                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //imena novinara visevrednosni
        public IEnumerable<ImenaNovinara> GetINovinara()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<ImenaNovinara> pm = s.Query<ImenaNovinara>().Select(p => p);
            foreach (ImenaNovinara p in pm)
            {
                p.id_intervjui_stampa = null;

            }
            return pm;
        }
        public ImenaNovinara GetINovinara(int id)
        {
            ISession s = DataLayer.GetSession();

            ImenaNovinara pm = s.Query<ImenaNovinara>().Where(x => x.id_imena_novinara == id).Select(p => p).FirstOrDefault();

            pm.id_intervjui_stampa = null;


            return pm;
        }

        public int AddINovinara(ImenaNovinara pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IntervjuiStampa mesto = s.Load<IntervjuiStampa>(103);
                mesto.novinari.Add(pan);
                pan.id_intervjui_stampa = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveINovinara(ImenaNovinara g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                IntervjuiStampa mesto = sa.Load<IntervjuiStampa>(103);

                mesto.novinari.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateINovinara(int id, ImenaNovinara g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_intervjui_stampa = s.Load<IntervjuiStampa>(id);

                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //pitanja visevrednosni
        public IEnumerable<Pitanja> GetPitanja()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Pitanja> pm = s.Query<Pitanja>().Select(p => p);
            foreach (Pitanja p in pm)
            {
                p.id_duel = null;

            }
            return pm;
        }

        public Pitanja GetPitanja(int id)
        {
            ISession s = DataLayer.GetSession();

            Pitanja pm = s.Query<Pitanja>().Where(x => x.id_pitanja == id).Select(p => p).FirstOrDefault();

            pm.id_duel = null;
            return pm;
        }
        public int AddPitanja(Pitanja pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Duel mesto = s.Load<Duel>(102);
                mesto.pitanja.Add(pan);
                pan.id_duel = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemovePitanja(Pitanja g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                Duel mesto = sa.Load<Duel>(102);

                mesto.pitanja.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdatePitanja(int t, Pitanja g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_duel = s.Load<Duel>(t);
                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //Protivkandidati visevrednosni
        public IEnumerable<Protivkandidati> GetPkandidati()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Protivkandidati> pm = s.Query<Protivkandidati>().Select(p => p);
            foreach (Protivkandidati p in pm)
            {
                p.id_duel = null;

            }
            return pm;
        }
        public Protivkandidati GetPkandidati(int id)
        {
            ISession s = DataLayer.GetSession();

            Protivkandidati pm = s.Query<Protivkandidati>().Where(x => x.id_protivkandidati == id).Select(p => p).FirstOrDefault();

            pm.id_duel = null;
            return pm;
        }
        public int AddPkandidati(Protivkandidati pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Duel mesto = s.Load<Duel>(102);
                mesto.pkandidati.Add(pan);
                pan.id_duel = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemovePkandidati(Protivkandidati g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                Duel mesto = sa.Load<Duel>(102);

                mesto.pkandidati.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdatePkandidati(int t, Protivkandidati g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                /*ISession sa = DataLayer.GetSession();
                DeljenjeLetaka mesto = sa.Load<DeljenjeLetaka>(g.id_deljenje_letaka);*/
                g.id_duel = s.Load<Duel>(t);
                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //email visevrednosni
        public IEnumerable<Email> GetIEmail()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Email> pm = s.Query<Email>().Select(p => p);
            foreach (Email p in pm)
            {
                p.id_aktivista = null;

            }
            return pm;
        }
        public Email GetIEmail(int id)
        {
            ISession s = DataLayer.GetSession();

            Email pm = s.Query<Email>().Where(x => x.id_email == id).Select(p => p).FirstOrDefault();
            pm.id_aktivista = null;

            return pm;
        }

        public int AddEmail(Email pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista mesto = s.Load<Aktivista>(87);
                mesto.email.Add(pan);
                pan.id_aktivista = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveEmail(Email g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                Aktivista mesto = sa.Load<Aktivista>(87);

                mesto.email.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateEmail(int id, Email g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_aktivista = s.Load<Aktivista>(id);

                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //brojevi telefona

        public IEnumerable<BrojeviTelefona> GetBTelefona()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<BrojeviTelefona> pm = s.Query<BrojeviTelefona>().Select(p => p);
            foreach (BrojeviTelefona p in pm)
            {
                p.id_aktivsta = null;

            }
            return pm;
        }
        public BrojeviTelefona GetBTelefona(int id)
        {
            ISession s = DataLayer.GetSession();

            BrojeviTelefona pm = s.Query<BrojeviTelefona>().Where(x => x.id_brojevi_telefona == id).Select(p => p).FirstOrDefault();
            pm.id_aktivsta = null;

            return pm;
        }

        public int AddBTelefona(BrojeviTelefona pan)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista mesto = s.Load<Aktivista>(87);
                mesto.brojevi.Add(pan);
                pan.id_aktivsta = mesto;
                s.SaveOrUpdate(mesto);
                s.Save(pan);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveBTelefona(BrojeviTelefona g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ISession sa = DataLayer.GetSession();
                Aktivista mesto = sa.Load<Aktivista>(87);

                mesto.brojevi.Remove(g);


                sa.SaveOrUpdate(mesto);
                s.Delete(g);
                s.Flush();
                s.Close();
                sa.Flush();
                sa.Close();
                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }

        public int UpdateBTelefona(int id, BrojeviTelefona g)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                g.id_aktivsta = s.Load<Aktivista>(id);

                s.Update(g);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
