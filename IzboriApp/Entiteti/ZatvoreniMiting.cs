using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class ZatvoreniMiting : PolitickiMiting
    {
        
        public virtual int cena_iznajmljivanja { get; set; }
        public virtual string iznajmljivac { get; set; }
    }
}
