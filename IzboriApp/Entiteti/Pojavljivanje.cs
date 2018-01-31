using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzboriApp.Entiteti
{
    public class Pojavljivanje
    {
        public virtual int id { get; set; }
        public virtual string grad { get; set; }
    }

    public class IntervjuiStampa : Pojavljivanje
    {
        public virtual string naziv_lista { get; set; }
        public virtual DateTime datum_intervjua { get; set; }
        public virtual DateTime datum_objavljivanja { get; set; }

        public virtual IList<ImenaNovinara> novinari { get; set; }

        public IntervjuiStampa()
        {
            novinari = new List<ImenaNovinara>();
        }
    }

    public class RTV : Pojavljivanje
    {
        public virtual string naziv { get; set; }
        public virtual string emisija { get; set; }
        public virtual string voditelj { get; set; }
        public virtual float gledanost { get; set; }
    }

    public class Duel : Pojavljivanje
    {
        public virtual IList<Pitanja> pitanja { get; set; }
        public virtual IList<Protivkandidati> pkandidati { get; set; }

        public Duel()
        {
            pitanja = new List<Pitanja>();
            pkandidati = new List<Protivkandidati>();
        }
    }
}
