using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using IzboriApp;
using IzboriApp.Entiteti;


namespace IzboriMVC.Controllers
{
    public class GlasackoMestoController : ApiController
    {

        // GET: /GlasackoMesto/
        public IEnumerable<GlasackoMesto> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetGlasackoMesto();
        }
        public GlasackoMesto Get(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.GetGlasackoMesto(id);
        }

        public int Post(GlasackoMesto glasMesto)
        {
            DataProvider provider = new DataProvider();
            return provider.AddGlasackoMesto(glasMesto);
        }

        public int Put(GlasackoMesto glasMesto)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateGlasackoMesto(glasMesto);
        }

        public int Delete(int id)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveGlasackoMesto(id);
        }



    }
}
