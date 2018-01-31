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
    public class PitanjaController : ApiController
    {
        //
        // GET: /Pitanja/
        public IEnumerable<Pitanja> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetPitanja();
        }
        public Pitanja Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPitanja(id);
        }

        public int Post(Pitanja g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPitanja(g);
        }

        public int Put(int id, [FromBody]Pitanja g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePitanja(id, g);
        }

        public int Delete(Pitanja g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePitanja(g);
        }

    }
}
