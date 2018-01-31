using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Akcije
    {
        public virtual int id { get; set; }
        public virtual string naziv { get; set; }
        public virtual string grad { get; set; }

        public virtual IList<Aktivista> aktiviste { get; set; }

        //treba veza m:n ucestvuje

        public Akcije()
        {
            aktiviste = new List<Aktivista>();
        }
    }
}
