using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IzboriApp.Entiteti
{
    [DataContract]
    [KnownType(typeof(Aktivista))]
    public class Aktivista
    {

        [DataMember]
        public virtual int id { get; set; }
        [DataMember]
        public virtual string ime { get; set; }
        [DataMember]
        public virtual string imeRoditelja { get; set; }
        [DataMember]
        public virtual string prezime { get; set; }
        [DataMember]
        public virtual DateTime datumRodjenja { get; set; }
        [DataMember]
        public virtual string adresa { get; set; }
        [DataMember]
        public virtual GlasackoMesto Dezura { get; set; }
        [DataMember]
        public virtual Koordinator Nadredjen { get; set; }
        [DataMember]
        public virtual IList<Email> email { get; set; }
        [DataMember]
        public virtual IList<Akcije> akcije { get; set; }
        [DataMember]
        public virtual IList<BrojeviTelefona> brojevi { get; set; }

        public Aktivista()
        {
            akcije = new List<Akcije>();
            email = new List<Email>();
            brojevi = new List<BrojeviTelefona>();
        }
    }
    [DataContract]
    [KnownType(typeof(Koordinator))]
    public class Koordinator : Aktivista
    {
        //public virtual int id_koordinator { get; set; }
        [DataMember]
        public virtual string imeOpstine { get; set; }
        [DataMember]
        public virtual string adresaKancelarije { get; set; }
        [DataMember]
        public virtual IList<Aktivista> Pomocnici {get; set;}

        public Koordinator()
        {
            Pomocnici = new List<Aktivista>();
        }
    }
}
