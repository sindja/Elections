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
    class DeljenjeLetakaMap : SubclassMap<DeljenjeLetaka>
    {
        public DeljenjeLetakaMap()
        {
            Table("DELJENJE_LETAKA");

            KeyColumn("ID");

            HasMany(x => x.lokacija).KeyColumn("ID_AKCIJE");
        }
    }
}
