using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Gost
    {
        public virtual int id { get; set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual string funkcija { get; set; }
        public virtual string titula { get; set; }

        public virtual PolitickiMiting PrisustvujeN { get; set; }
    }
}
