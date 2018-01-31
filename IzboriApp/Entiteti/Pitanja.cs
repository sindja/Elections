using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzboriApp.Entiteti
{
    public class Pitanja
    {
        public virtual int id_pitanja { get; set; }
        public virtual Duel id_duel { get; set; }
        public virtual string pitanja { get; set; }
    }
}
