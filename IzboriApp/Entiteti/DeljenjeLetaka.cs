using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class DeljenjeLetaka : Akcije
    {
      
        public virtual IList<Lokacije> lokacija { get; set; }

        public DeljenjeLetaka()
        {
            lokacija = new List<Lokacije>();
        }
    }
}
