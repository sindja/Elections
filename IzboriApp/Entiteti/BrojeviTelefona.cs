using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class BrojeviTelefona
    {
        public virtual int id_brojevi_telefona { get; set; }
        public virtual string brojevi_telefona { get; set; }
        public virtual Aktivista id_aktivsta { get; set; }
    }
}
