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
    public class EmailController : ApiController
    {

        public IEnumerable<Email> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetIEmail();
        }
        public Email Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetIEmail(id);
        }


        public int Post(Email g)
        {
            DataProvider provider = new DataProvider();
            return provider.AddEmail(g);
        }

        public int Put(int id, [FromBody] Email g)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateEmail(id, g);
        }

        public int Delete(Email g)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveEmail(g);
        }
    }
}
