using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using IzboriApp;
using IzboriApp.Entiteti;

namespace IzboriMVC.Controllers
{
    public class RTVController : ApiController
    {
        public IEnumerable<RTV> Get()
        {
            DataProvider provider = new DataProvider();
            return provider.GetRTV();
        }
        public RTV Get(int id)
        {
            DataProvider provider = new DataProvider();

            RTV rtv = provider.GetRTV(id);

            return rtv;
        }

        public int Post(RTV rtv)
        {
            DataProvider provider = new DataProvider();
            return provider.AddRTV(rtv);
        }

        public int Put(RTV rtv)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateRTV(rtv);
        }

        public int Delete(RTV rtv)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveRTV(rtv);
        }
    }
}