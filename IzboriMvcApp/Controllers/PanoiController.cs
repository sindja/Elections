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
    public class PanoiController : ApiController
    {
        public IEnumerable<Panoi> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<Panoi> panoi = provider.GetPanoi();

            return panoi;
        }
        public Panoi Get(int id)
        {
            DataProvider provider = new DataProvider();

            Panoi panoi = provider.GetPanoi(id);

            return panoi;
        }
        public int Post(Panoi pan)
        {
            DataProvider provider = new DataProvider();

            return provider.AddPanoi(pan);
        }

        public int Delete(Panoi pano)
        {
            DataProvider provider = new DataProvider();
            return provider.RemovePanoi(pano);
        }

        public int Put(Panoi pano)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdatePanoi(pano);
        }
    }
}