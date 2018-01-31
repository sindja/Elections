using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using IzboriApp;
using IzboriApp.Entiteti;

namespace IzboriMVC.Controllers
{
    public class SusretiKandidataController : ApiController
    {

        // GET: /SusretiKandidata/
        public IEnumerable<SusretiKandidata> Get()
        {
            DataProvider provider = new DataProvider();
            IEnumerable<SusretiKandidata> a = provider.GetSusrete();
            return a;
        }
        public SusretiKandidata Get(int id)
        {
            DataProvider provider = new DataProvider();
            SusretiKandidata a = provider.GetSusrete(id);
            return a;
        }

        public int Post(SusretiKandidata akt)
        {
            DataProvider provider = new DataProvider();
            return provider.AddSusret(akt);
        }

        public int Put(SusretiKandidata akt)
        {
            DataProvider provider = new DataProvider();
            return provider.UpdateSusret(akt);
        }

        public int Delete(SusretiKandidata s)
        {
            DataProvider provider = new DataProvider();
            return provider.RemoveSusret(s);
        }


    }
}
