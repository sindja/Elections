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
    public partial class DataProvider
    {
       

        //Panoi
        public IEnumerable<Panoi> GetPanoi()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Panoi> panoi = s.Query<Panoi>().Where(x => x.iznos > 1500).Select(p => p);

            return panoi;
        }
        public Panoi GetPanoi(int id)
        {
            ISession s = DataLayer.GetSession();

            Panoi panoi = s.Query<Panoi>().Where(x => x.id > id).Select(p => p).FirstOrDefault();

            return panoi;
        }
        public int AddPanoi(Panoi pan)
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

        public int RemovePanoi(Panoi pano)
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

        public int UpdatePanoi(Panoi pano)
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

        //R_TV
        public IEnumerable<R_TV> GetR_TV()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<R_TV> r_tv = s.Query<R_TV>().Select(p => p);

            return r_tv;
        }
        public R_TV GetR_TV(int id)
        {
            ISession s = DataLayer.GetSession();

             R_TV  r_tv = s.Query<R_TV>().Where(x => x.id == id).Select(p => p).FirstOrDefault();

            return r_tv;
        }

        public int AddR_TV(R_TV r_tv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(r_tv);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveR_TV(R_TV r_tv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(r_tv);

                s.Flush();
                s.Close();
                return 1;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public int UpdateR_TV(R_TV r_tv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(r_tv);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //Stampa
        public IEnumerable<Stampa> GetStampa()
        {
            ISession s = DataLayer.GetSession();

            IEnumerable<Stampa> stampa = s.Query<Stampa>().Select(p => p);
            return stampa;
        }

        public  Stampa GetStampa(int id)
        {
            ISession s = DataLayer.GetSession();
            Stampa stampa = s.Query<Stampa>().Where(x => x.id == id).Select(p => p).FirstOrDefault();
            return stampa;
        }

        public int AddStampa(Stampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(stampa);

                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveStampa(Stampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(stampa);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateStampa(Stampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(stampa);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

      
        //RTV
        public IEnumerable<RTV> GetRTV()
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<RTV> rtv = s.Query<RTV>().Select(p => p);
            return rtv;
        }
        public  RTV GetRTV(int id)
        {
            ISession s = DataLayer.GetSession();
             RTV  rtv = s.Query<RTV>().Where(x => x.id == id).Select(p => p).FirstOrDefault();
            return rtv;
        }
        public int AddRTV(RTV rtv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(rtv);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int UpdateRTV(RTV rtv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(rtv);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveRTV(RTV rtv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(rtv);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //IntervjuiStampa 
        public IEnumerable<IntervjuiStampa> GetIntervjuiStampa()
        {
            ISession s = DataLayer.GetSession();
            IEnumerable<IntervjuiStampa> stampa = s.Query<IntervjuiStampa>().Where(x => x.id > 0).Select(p => p);           
            foreach(IntervjuiStampa k in stampa)
            {
                k.novinari = null;
            }
            return stampa;
        }
        public IntervjuiStampa GetIntervjuiStampa(int id)
        {
            ISession s = DataLayer.GetSession();
            IntervjuiStampa k = s.Query<IntervjuiStampa>().Where(x => x.id == id).Select(p => p).FirstOrDefault();
            
                k.novinari = null;
           
            return k;
        }

        public int AddIntervjuiStampa(IntervjuiStampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(stampa);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            };
        }

        public int UpdateIntervjuiStampa(IntervjuiStampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(stampa);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int RemoveIntervjuiStampa(IntervjuiStampa stampa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Delete(stampa);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

     
        //Aktivista


        public int UpdateAktivista(Aktivista akt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Update(akt);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int RemoveAktivista(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Aktivista akt = s.Load<Aktivista>(id);
                s.Delete(akt);
                s.Flush();
                s.Close();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public Aktivista GetAktivista(int id)
        {
            ISession s = DataLayer.GetSession();
            Aktivista a = s.Load<Aktivista>(id);
            a.brojevi = null;
            a.email = null;
            a.Dezura = null;
            a.akcije = null;
            
         //  Aktivista a = s.Query<Aktivista>().Where(x => x.id == id).Select(ak => ak).FirstOrDefault();
           a.Nadredjen = null;
             a = (Aktivista)s.GetSessionImplementation().PersistenceContext.Unproxy(a);
            return a;
        }

        public IEnumerable<Aktivista> GetAktivista()
        {
            ISession s = DataLayer.GetSession();

            
            IEnumerable<Aktivista> a = s.Query<Aktivista>().Select(ak => ak);
            IList<Aktivista> akt = new List<Aktivista>();
            foreach (Aktivista ak in a)
            {
                Aktivista novi = new Aktivista();
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
                //ak = (Aktivista)s.GetSessionImplementation().PersistenceContext.Unproxy(ak);
                akt.Add(novi);
            }
            a = akt;
            return akt;
        }

        public int AddAktivista(Aktivista akt)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.Save(akt);

                s.Flush();
                s.Close();

                return 1;
            }
            catch (Exception ec)
            {
                return -1;
            }
        }
    }

}
