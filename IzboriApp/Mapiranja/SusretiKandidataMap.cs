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
    class SusretiKandidataMap : SubclassMap<SusretiKandidata>
    {
        public SusretiKandidataMap()
        {
            Table("SUSRETI_KANDIDATA");

            KeyColumn("ID");

            Map(x => x.lokacija).Column("LOKACIJA").Not.Nullable();
            Map(x => x.trajanje).Column("TRAJANJE");
        }
    }
}
