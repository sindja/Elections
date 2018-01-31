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
    class AkcijeMap : ClassMap<Akcije>
    {
        public AkcijeMap()
        {
            Table("AKCIJE");

            Id(x => x.id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.naziv).Column("NAZIV");
            Map(x => x.grad).Column("GRAD");

            //veza m:n ucestvuje
            HasManyToMany(x => x.aktiviste).Table("UCESTVUJE")
                                            .ParentKeyColumn("ID_AKCIJE")
                                            .ChildKeyColumn("ID_AKTIVISTA")
                                            .Inverse()
                                            .Cascade.All();
        }
    }
}
