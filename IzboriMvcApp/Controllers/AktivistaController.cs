using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using IzboriApp;
using IzboriApp.Entiteti;

namespace IzboriMVC.Controllers
{
    public class AktivistaController : ApiController
    {

        // /Aktivista/
        public Aktivista Get(int id)
        {
            DataProvider provider = new DataProvider();
            Aktivista a = provider.GetAktivista(id);
            return a;
        }

        public IEnumerable<Aktivista> Get()
        {
            DataProvider provider = new DataProvider();
            IEnumerable<Aktivista> a = provider.GetAktivista();
            return a;
        }

        public int Post(Aktivista akt)
        {
            DataProvider provider = new DataProvider();
            return provider.AddAktivista(akt);
        }

        public int Put(Aktivista akt)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateAktivista(akt);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveAktivista(id);
        }

    }
}
