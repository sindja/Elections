using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzboriApp.Entiteti
{
    public class Protivkandidati
    {
        public virtual int id_protivkandidati { get; set; }
        public virtual Duel id_duel { get; set; }
        public virtual string protivkandidati { get; set; }

    }
}
