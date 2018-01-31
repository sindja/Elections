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
    class PrimedbeMap : ClassMap<Primedbe>
    {
        public PrimedbeMap()
        {
            Table("PRIMEDBE");

            Id(x => x.id_primedbe, "ID_PRIMEDBE").GeneratedBy.TriggerIdentity();

            Map(x => x.primedbe,"PRIMEDBE");

            References(x => x.id_glasacko_mesto).Column("ID_GLASACKO_MESTO").LazyLoad();
        }
    }
}
