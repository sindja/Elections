using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IzboriApp.Entiteti
{
    public class ImenaNovinara
    {
        public virtual int id_imena_novinara { get; set; }
        public virtual string imena_novirana  { get; set; }
        public virtual IntervjuiStampa id_intervjui_stampa { get; set; }

    }
}