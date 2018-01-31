using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Lokacije
    {
        public virtual int id_lokacije { get; set; }
        public virtual string lokacije { get; set; }
        public virtual DeljenjeLetaka id_deljenje_letaka { get; set; }
    }
}
