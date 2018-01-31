using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using IzboriApp.Entiteti;

namespace IzboriApp.Mapiranja
{
    class GostMap : ClassMap<Gost>
    {

        public GostMap()
        {
            Table("GOST");

            Id(x => x.id, "ID_GOST").GeneratedBy.TriggerIdentity();

            Map(x => x.ime).Column("IME");
            Map(x => x.prezime).Column("PREZIME");
            Map(x => x.funkcija).Column("FUNKCIJA");
            Map(x => x.titula).Column("TITULA");

            References(x => x.PrisustvujeN).Column("ID_AKCIJE");
        }
    }
}
