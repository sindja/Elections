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
    public class R_TVController : ApiController
    {
        public IEnumerable<R_TV> Get()
        {
            DataProvider provider = new DataProvider();

            IEnumerable<R_TV> r_tv = provider.GetR_TV();

            return r_tv;
        }
        public R_TV Get(int id)
        {
            DataProvider provider = new DataProvider();

            R_TV r_tv = provider.GetR_TV(id);

            return r_tv;
        }
        public int Post(R_TV r_tv)
        {
            DataProvider provider = new DataProvider();

            return provider.AddR_TV(r_tv);
        }

        public int Delete(R_TV r_tv)
        {
            DataProvider provider = new DataProvider();

            return provider.RemoveR_TV(r_tv);
        }

        public int Put(R_TV r_tv)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateR_TV(r_tv);
        }
    }
}