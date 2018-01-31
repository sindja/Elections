using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzboriApp.Entiteti
{
    public class GlasackoMesto
    {
        public virtual int id { get; set; }
        public virtual int broj { get; set; }
        public virtual string grad { get; set; }
        public virtual string naziv { get; set; }
        public virtual int brojBiracaI { get; set; }
        public virtual float procenatOsvojenihGlasovaI { get; set; }
        public virtual int brojBiracaII { get; set; }
        public virtual float procenatOsvojenihGlasovaII { get; set; }

        public virtual IList<Aktivista> GlmAktiviste { get; set; }
        public virtual IList<Primedbe> primedbe { get; set; }

        public GlasackoMesto()
        {
            GlmAktiviste = new List<Aktivista>();
            primedbe = new List<Primedbe>();
        }
    }
}
