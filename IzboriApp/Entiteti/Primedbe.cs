using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Primedbe
    {
        public virtual int id_primedbe { get; set; }
        public virtual string primedbe { get; set; }
        public virtual GlasackoMesto id_glasacko_mesto { get; set; }
    }

}
