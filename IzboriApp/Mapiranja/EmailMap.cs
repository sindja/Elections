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
    class EmailMap : ClassMap<Email>
    {
        public EmailMap()
        {
            Table("EMAIL");

            Id(x => x.id_email, "ID_EMAIL").GeneratedBy.TriggerIdentity();

            Map(x => x.email, "EMAIL");

            References(x => x.id_aktivista).Column("ID_AKTIVISTA").LazyLoad();

        }
    }
}
