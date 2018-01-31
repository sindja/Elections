using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzboriApp.Entiteti
{
    public class Email
    {
        public virtual int id_email { get; set; }
        public virtual string email { get; set; }
        public virtual Aktivista id_aktivista { get; set; }
        
    }
}
