using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using IzboriApp.Entiteti; 

namespace IzboriApp.Mapiranja
{
    class AktivistaMap : ClassMap<Aktivista> {

        public AktivistaMap()
        {
            Table("AKTIVISTA");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.ime).Column("IME");
            Map(x => x.imeRoditelja).Column("IME_RODITELJA");
            Map(x => x.prezime).Column("PREZIME");
            Map(x => x.datumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.adresa).Column("ADRESA");

            References(x => x.Dezura).Column("ID_BROJ_GLASACKOG_MESTA").LazyLoad();
            References(x => x.Nadredjen).Column("ID_KOORDINATOR").LazyLoad();

            HasMany(x => x.email).KeyColumn("ID_AKTIVISTA").LazyLoad();
            HasMany(x => x.brojevi).KeyColumn("ID_AKTIVISTA");
            //veza m:n ucestvuje
            HasManyToMany(x => x.akcije).Table("UCESTVUJE")
                                            .ParentKeyColumn("ID_AKTIVISTA")
                                            .ChildKeyColumn("ID_AKCIJE");
        }
    }

    class KoordinatorMap : SubclassMap<Koordinator>
    {
        public KoordinatorMap()
        {
            Table("KOORDINATOR");

            KeyColumn("ID_AKTIVISTA");

            Map(x => x.imeOpstine).Column("IME_OPSTINE");
            Map(x => x.adresaKancelarije).Column("ADRESA_KANCELARIJE");

            //References(x => x.id_koordinator).Column("ID_AKTIVISTA");

            HasMany(x => x.Pomocnici).KeyColumn("ID_KOORDINATOR");
        }
    }
}
