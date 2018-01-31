using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IzboriApp.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace IzboriApp.Mapiranja
{
    class ReklamniProstorMap : ClassMap<ReklamniProstor>
    {
        public ReklamniProstorMap()
        {
            //mapiranje tabele
            Table("REKLAMNI_PROSTOR");

            //mapiranje primarnog kljuca
            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.iznos).Column("IZNOS");
            Map(x => x.pocetakReklamiranja).Column("POCETAK_REKLAMIRANJA");
            Map(x => x.krajReklamiranja).Column("KRAJ_REKLAMIRANJA");
           
        }
    }

    class PanoiMap : SubclassMap<Panoi>
    {
        public PanoiMap()
        {
            Table("PANOI");

            KeyColumn("ID_PANOI");

            Map(x => x.adresa).Column("ADRESA").Not.Nullable();
            Map(x => x.nazivAgencije).Column("NAZIV_AGENCIJE").Not.Nullable();
            Map(x => x.grad).Column("GRAD").Not.Nullable();
            Map(x => x.povrsinaPanoa).Column("POVRSINA_PANOA");
        }
    }

    class R_TVMap : SubclassMap<R_TV>
    {
        public R_TVMap()
        {
            Table("R_TV");

            KeyColumn("ID_R_TV");

            Map(x => x.trajanje).Column("TRAJANJE");
            Map(x => x.nazivStanice).Column("NAZIV_STANICE").Not.Nullable();
            Map(x => x.brojEmitovanja).Column("BROJ_EMITOVANJA");
        }
    }

    class StampaMap : SubclassMap<Stampa>
    {
        public StampaMap()
        {
            Table("STAMPA");

            KeyColumn("ID_STAMPA");

            Map(x => x.kolor).Column("KOLOR");
            Map(x => x.nazivLista).Column("NAZIV_LISTA").Not.Nullable();
        }
    }

    
}
