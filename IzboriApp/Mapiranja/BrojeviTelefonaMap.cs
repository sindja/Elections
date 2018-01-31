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
    class BrojeviTelefonaMap : ClassMap<BrojeviTelefona>
    {
        public BrojeviTelefonaMap()
        {
            Table("BROJEVI_TELEFONA");

            Id(x => x.id_brojevi_telefona, "ID_BROJEVI_TELEFONA").GeneratedBy.TriggerIdentity();

            Map(x => x.brojevi_telefona, "BROJEVI_TELEFONA");

            References(x => x.id_aktivsta).Column("ID_AKTIVISTA").LazyLoad();

        }
    }
}
