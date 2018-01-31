using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace IzboriApp.Entiteti
{
    
    public class ReklamniProstor
    {
        public virtual int id { get; set; }
        public virtual int iznos { get; set; }
        public virtual DateTime pocetakReklamiranja { get; set; }
        public virtual DateTime krajReklamiranja { get; set; }
    }
    
    public class Panoi : ReklamniProstor
    {
        public virtual string grad { get; set; }
        public virtual string adresa { get; set; }
        public virtual string nazivAgencije { get; set; }
        public virtual short povrsinaPanoa { get; set; }
    }

    public class R_TV : ReklamniProstor
    {
        public virtual int trajanje { get; set; }
        public virtual string nazivStanice { get; set; }
        public virtual short brojEmitovanja { get; set; }
    }

    public class Stampa : ReklamniProstor
    {
        public virtual string nazivLista { get; set; }
        public virtual string kolor { get; set; }
    }
}
