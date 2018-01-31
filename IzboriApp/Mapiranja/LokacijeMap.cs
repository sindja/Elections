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
    class LokacijeMap : ClassMap<Lokacije>
    {
        public LokacijeMap()
        {
            Table("LOKACIJE");

            Id(x => x.id_lokacije, "ID_LOKACIJE").GeneratedBy.TriggerIdentity();

            Map(x => x.lokacije, "LOKACIJA");

            References(x => x.id_deljenje_letaka).Column("ID_AKCIJE").LazyLoad();

        }
    }
}
