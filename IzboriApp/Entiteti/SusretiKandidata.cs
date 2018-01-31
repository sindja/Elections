using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class SusretiKandidata : Akcije
    {
        public virtual string lokacija { get; set; }
        public virtual int trajanje { get; set; }

    }
}
