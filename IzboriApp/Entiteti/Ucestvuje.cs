using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Ucestvuje
    {
        public virtual int id_ucestvuje { get; set; }
        public virtual Aktivista UcestvujeAktivista { get; set; }
        public virtual Akcije UcestvujeAkcije { get; set; }

    }
}
