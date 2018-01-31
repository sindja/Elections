using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class PolitickiMiting : Akcije
    {
        public virtual string lokacija { get; set; }
        public virtual IList<Gost> Prisustvuje { get; set; }
        public PolitickiMiting()
        {
            Prisustvuje = new List<Gost>();
        }
    }
}
