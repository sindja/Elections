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
    class PojavljivanjaMap : ClassMap<Pojavljivanje>
    {
        public PojavljivanjaMap()
        {
            Table("POJAVLJIVANJE");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.grad, "GRAD");
        }
    }

    class IntervjuiStampaMap : SubclassMap<IntervjuiStampa>
    {
        public IntervjuiStampaMap()
        {
            Table("INTERVJUI_STAMPA");

            KeyColumn("ID");

            Map(x => x.naziv_lista).Column("NAZIV_LISTA").Not.Nullable();
            Map(x => x.datum_intervjua).Column("DATUM_INTERVJUA");
            Map(x => x.datum_objavljivanja).Column("DATUM_OBJAVLJIVANJA");

            HasMany(x => x.novinari).KeyColumn("ID_INTERVJUI_STAMPA");
        }
    }

    class DuelMap : SubclassMap<Duel>
    {
        public DuelMap()
        {
            Table("DUEL");

            KeyColumn("ID_DUEL");

            HasMany(x => x.pitanja).KeyColumn("ID_DUEL");
            HasMany(x => x.pkandidati).KeyColumn("ID_POJAVLJIVANJE");
        }
    }

    class RTVMap : SubclassMap<RTV>
    {
        public RTVMap()
        {
            Table("RTV");

            KeyColumn("ID_RTV");

            Map(x => x.naziv).Column("NAZIV");
            Map(x => x.gledanost).Column("GLEDANOST");
            Map(x => x.voditelj).Column("IME_VODITELJA");
            Map(x => x.emisija).Column("EMISIJA");
        }
    }
}
