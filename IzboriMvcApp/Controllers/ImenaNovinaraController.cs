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
    public class ImenaNovinaraController : ApiController
    {
        //
        // GET: /ImenaNovinara/
        public IEnumerable<ImenaNovinara> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetINovinara();
        }
        public ImenaNovinara Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetINovinara(id);
        }

        public int Post(ImenaNovinara g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddINovinara(g);
        }

        public int Put(int id, [FromBody] ImenaNovinara g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateINovinara(id, g);
        }

        public int Delete(ImenaNovinara g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveINovinara(g);
        }

    }
}
