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
    class ProtivkandidatiMap : ClassMap<Protivkandidati>
    {
        public ProtivkandidatiMap()
        {
            Table("PROTIVKANDIDATI");

            Id(x => x.id_protivkandidati, "ID_PROTIVKANDIDATI").GeneratedBy.TriggerIdentity();

            Map(x => x.protivkandidati, "PROTIVKANDIDATI");

            References(x => x.id_duel).Column("ID_POJAVLJIVANJE").LazyLoad();
        }
    }
}
