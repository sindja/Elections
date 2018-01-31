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
    class GlasackoMestoMap : ClassMap<GlasackoMesto>
    {

        public GlasackoMestoMap()
        {
            Table("GLASACKO_MESTO");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.broj).Column("BROJ");
            Map(x => x.naziv).Column("NAZIV");
            Map(x => x.grad).Column("GRAD");
            Map(x => x.brojBiracaI).Column("BROJ_BIRACA_I");
            Map(x => x.procenatOsvojenihGlasovaI).Column("PROCENAT_OSOVOJENIH_GLASOVA_I");
            Map(x => x.brojBiracaII).Column("BROJ_BIRACA_II");
            Map(x => x.procenatOsvojenihGlasovaII).Column("PROCENAT_OSOVOJENIH_GLASOVA_II");

            HasMany(x => x.GlmAktiviste).KeyColumn("ID_BROJ_GLASACKOG_MESTA");
            HasMany(x => x.primedbe).KeyColumn("ID_GLASACKO_MESTO");
        }
    }
}
