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
    public class BrojeviTelefonaController : ApiController
    {

        public IEnumerable<BrojeviTelefona> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetBTelefona();
        }
        public BrojeviTelefona Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetBTelefona(id);
        }


        public int Post(BrojeviTelefona g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddBTelefona(g);
        }

        public int Put(int id, [FromBody] BrojeviTelefona g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateBTelefona(id, g);
        }

        public int Delete(BrojeviTelefona g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveBTelefona(g);
        }
    }
}
