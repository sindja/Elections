using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping;
using IzboriApp.Entiteti;
using FluentNHibernate.Mapping;


namespace IzboriApp.Mapiranja
{
    class ZatvoreniMitingMap : SubclassMap<ZatvoreniMiting>
    {
        public ZatvoreniMitingMap()
        {
            Table("ZATVORENI_MITING");

            KeyColumn("ID");

            Map(x => x.iznajmljivac).Column("IZNAJMLJIVAC").Not.Nullable();
            Map(x => x.cena_iznajmljivanja).Column("CENA_IZNAJMLJIVANJA");
        }
    }
}
