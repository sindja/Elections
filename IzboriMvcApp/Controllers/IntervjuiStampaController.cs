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
    public class IntervjuiStampaController : ApiController
    {

        // GET: intervjuistampa

        public IEnumerable<IntervjuiStampa> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetIntervjuiStampa();
        }
        public IntervjuiStampa Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetIntervjuiStampa(id);
        }

        public int Post(IntervjuiStampa g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddIntervjuiStampa(g);
        }

        public int Put(IntervjuiStampa g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateIntervjuiStampa(g);
        }

        public int Delete(IntervjuiStampa g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveIntervjuiStampa(g);
        }

    }
}


