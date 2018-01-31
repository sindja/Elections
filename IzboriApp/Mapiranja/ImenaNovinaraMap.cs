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
    class ImenaNovinaraMap : ClassMap<ImenaNovinara>
    {
        public ImenaNovinaraMap()
        {
            Table("IMENA_NOVINARA");

            Id(x => x.id_imena_novinara, "ID_IMENA_NOVINARA").GeneratedBy.TriggerIdentity();

            Map(x => x.imena_novirana, "IMENA_NOVINARA");

            References(x => x.id_intervjui_stampa).Column("ID_INTERVJUI_STAMPA").LazyLoad();

        }
    }
}
