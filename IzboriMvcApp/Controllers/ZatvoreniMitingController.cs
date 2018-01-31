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
    public class ZatvoreniMitingController : ApiController
    {
        //
        // GET: /ZatvoreniMiting/
        public IEnumerable<ZatvoreniMiting> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<ZatvoreniMiting> pm = provider.GetZatvoreniM();

            return pm;
        }
        public ZatvoreniMiting Get(int id)
        {
            DataProvider provider = new DataProvider();

            ZatvoreniMiting pm = provider.GetZatvoreniM(id);

            return pm;
        }
        public int Post(ZatvoreniMiting pan)
        {
            DataProvider provider = new DataProvider();

            return provider.AddZatvoreniM(pan);
        }

        public int Delete(ZatvoreniMiting pano)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveZatvoreniM(pano);
        }

        public int Put(ZatvoreniMiting pano)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateZatvoreniM(pano);
        }

    }
}
