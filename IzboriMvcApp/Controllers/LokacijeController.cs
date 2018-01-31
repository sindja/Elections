using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using IzboriApp.Entiteti;
using IzboriApp;

namespace IzboriMVC
{
    public class LokacijeController : ApiController
    {
        public IEnumerable<Lokacije> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetLokacije();
        }
        public Lokacije Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetLokacije(id);
        }

        public int Post(Lokacije g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddLokacije(g);
        }

        public int Put(int id, [FromBody]Lokacije g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateLokacije(id, g);
        }

        public int Delete(Lokacije g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveLokacije(g);
        }
    }
}
