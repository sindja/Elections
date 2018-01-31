using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using IzboriApp.Mapiranja;
using System.Windows.Forms;

namespace IzboriApp
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        //Funkcija na zahtev otvara sesiju...
        public static ISession GetSession()
        {
            //Ukoliko session factory nije kreiran...
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }
            return _factory.OpenSession();
        }

        //Konfiguracija i kreiranje session factory...
        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleClientConfiguration.Oracle10
                        .ConnectionString(c =>
                        c.Is("DATA SOURCE=160.99.9.199:1521/gislab.elfak.ni.ac.rs;PERSIST SECURITY INFO=True;USER ID=S14500;Password=S14500"));

                return Fluently.Configure().Database(cfg)
                    .Mappings(m => m.FluentMappings.Add<ReklamniProstorMap>())
                    .Mappings(m => m.FluentMappings.Add<PanoiMap>())
                    .Mappings(m => m.FluentMappings.Add<StampaMap>())
                    .Mappings(m => m.FluentMappings.Add<R_TVMap>())
                    .Mappings(m => m.FluentMappings.Add<PojavljivanjaMap>())
                    .Mappings(m => m.FluentMappings.Add<RTVMap>())
                    .Mappings(m => m.FluentMappings.Add<DuelMap>())
                    .Mappings(m => m.FluentMappings.Add<IntervjuiStampaMap>())
                    .Mappings(m => m.FluentMappings.Add<PitanjaMap>())
                    .Mappings(m => m.FluentMappings.Add<ProtivkandidatiMap>())
                    .Mappings(m => m.FluentMappings.Add<ImenaNovinaraMap>())
                    .Mappings(m => m.FluentMappings.Add<GlasackoMestoMap>())
                    .Mappings(m => m.FluentMappings.Add<PrimedbeMap>())
                    .Mappings(m => m.FluentMappings.Add<AktivistaMap>())
                    .Mappings(m => m.FluentMappings.Add<EmailMap>())
                    .Mappings(m => m.FluentMappings.Add<BrojeviTelefonaMap>())
                    .Mappings(m => m.FluentMappings.Add<KoordinatorMap>())
                    .Mappings(m => m.FluentMappings.Add<AkcijeMap>())
                    .Mappings(m => m.FluentMappings.Add<DeljenjeLetakaMap>())
                    .Mappings(m => m.FluentMappings.Add<SusretiKandidataMap>())
                    .Mappings(m => m.FluentMappings.Add<PolitickiMitingMap>())
                    .Mappings(m => m.FluentMappings.Add<ZatvoreniMitingMap>())
                    .Mappings(m => m.FluentMappings.Add<GostMap>())
                    .Mappings(m => m.FluentMappings.Add<UcestvujeMap>())
                    .Mappings(m => m.FluentMappings.Add<LokacijeMap>())


                    //.ExposeConfiguration(BuildSchema) 
                .BuildSessionFactory();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

