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
    public class PrimedbeController : ApiController
    {

        public IEnumerable<Primedbe> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetPrimedbe();
        }
        public Primedbe Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPrimedbe(id);
        }
        public int Post(Primedbe g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPrimedbe(g);
        }

        public int Put(int id, [FromBody]Primedbe g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePrimedbe(id, g);
        }

        public int Delete(Primedbe g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePrimedbe(g);
        }


    }
}
