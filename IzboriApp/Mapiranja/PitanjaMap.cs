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
    class PitanjaMap : ClassMap<Pitanja>
    {
        public PitanjaMap()
        {
            Table("PITANJA");

            Id(x => x.id_pitanja, "ID_PITANJA").GeneratedBy.TriggerIdentity();

            Map(x => x.pitanja, "PITANJA");

            References(x => x.id_duel).Column("ID_PITANJA").LazyLoad();
        }
    }
}
