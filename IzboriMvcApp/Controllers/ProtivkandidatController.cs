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
    public class ProtivkandidatController : ApiController
    {
        //
        // GET: /PKandidat/

        public IEnumerable<Protivkandidati> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetPkandidati();
        }
        public Protivkandidati Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetPkandidati(id);
        }

        public int Post(Protivkandidati g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddPkandidati(g);
        }

        public int Put(int id, [FromBody] Protivkandidati g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePkandidati(id, g);
        }

        public int Delete(Protivkandidati g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePkandidati(g);
        }

    }
}
