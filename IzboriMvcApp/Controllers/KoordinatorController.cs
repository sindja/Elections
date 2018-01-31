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
    public class KoordinatorController : ApiController
    {
        //
        // GET: /Koordinator/
        public IEnumerable<Koordinator> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetKoordinatori();
        }
        public Koordinator Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetKoordinatori(id);
        }

        public int Post(Koordinator kor)
        {
            DataProvider provider = new DataProvider();
            return provider.AddKoordinator(kor);
        }

        public int Put(Koordinator kor)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateKoordinator(kor);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveKoordinator(id);
        }


    }
}
