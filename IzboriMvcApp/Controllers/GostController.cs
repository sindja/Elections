using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using IzboriApp.Entiteti;
using IzboriApp;

namespace IzboriMVC.Controllers
{
    public class GostController : ApiController
    {
        //
        // GET: /Gost/
        public IEnumerable<Gost> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetGost();
        }
        public Gost Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetGost(id);
        }

        public int Post(Gost g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddGost(g);
        }

        public int Put(Gost g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateGost(g);
        }

        public int Delete(Gost g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveGost(g);
        }
    }
}
