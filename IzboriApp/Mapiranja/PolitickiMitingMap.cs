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
    public class PolitickiMitingMap : SubclassMap<PolitickiMiting>
    {

        public PolitickiMitingMap()
        {
            Table("POLITICKI_MITING");

            KeyColumn("ID");

            Map(x => x.lokacija, "LOKACIJA");

            HasMany(x => x.Prisustvuje).KeyColumn("ID_AKCIJE");
        }
    }
}
