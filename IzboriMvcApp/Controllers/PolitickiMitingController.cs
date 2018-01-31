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
    public class PolitickiMitingController : ApiController
    {
        //
        // GET: /PolitickiMiting/
        public IEnumerable<PolitickiMiting> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<PolitickiMiting> pm = provider.GetPolitickiM();

            return pm;
        }
        public PolitickiMiting Get(int id)
        {
            DataProvider provider = new DataProvider();

            PolitickiMiting pm = provider.GetPolitickiM(id);

            return pm;
        }

        public int Post(PolitickiMiting pan)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPolitickiM(pan);
        }

        public int Delete(PolitickiMiting pano)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePolitickiM(pano);
        }

        public int Put(PolitickiMiting pano)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePolitickiM(pano);
        }

    }
}
