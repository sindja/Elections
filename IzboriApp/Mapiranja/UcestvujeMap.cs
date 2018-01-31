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
    class UcestvujeMap : ClassMap<Ucestvuje>
    {
        public UcestvujeMap()
        {
            Table("UCESTVUJE");

            Id(x => x.id_ucestvuje, "ID_UCESTVUJE").GeneratedBy.TriggerIdentity();

            References(x => x.UcestvujeAkcije).Column("ID_AKCIJE");
            References(x => x.UcestvujeAktivista).Column("ID_AKTIVISTA");
        }
    }
}
