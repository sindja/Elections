using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using IzboriApp;
using IzboriApp.Entiteti;

namespace IzboriMVC.Controllers
{
    public class StampaController : ApiController
    {
        public IEnumerable<Stampa> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Stampa> stampa = provider.GetStampa();

            return stampa;
        }
        public Stampa Get(int id)
        {
            DataProvider provider = new DataProvider();

            Stampa stampa = provider.GetStampa(id);

            return stampa;
        }

        public int Post(Stampa stamp)
        {
            DataProvider provider = new DataProvider();

            return provider.AddStampa(stamp);
        }

        public int Delete(Stampa stampa)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveStampa(stampa);
        }

        public int Put(Stampa stampa)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateStampa(stampa);
        }
    }
}