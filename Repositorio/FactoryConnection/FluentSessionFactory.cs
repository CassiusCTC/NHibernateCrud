using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;




namespace Repositorio.FactoryConnection
{
    public class FluentSessionFactory
    {
        private static string ConnectionString="Server=localhost; Port=3306; User Id=root; Password=++++++++++; Database=dbnhibernate";
        private static ISessionFactory session;
        public static ISessionFactory CreateSession()
        {
            
            if (session != null)
            {
                    return session;
            }
            IPersistenceConfigurer configDB =MySQLConfiguration.Standard.ConnectionString(ConnectionString);
            var configMap = Fluently.Configure().Database(configDB)//pega configuração db
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mapping.UsuariosMap>())//mapeia com base no mapeamentos feito
                    .BuildSessionFactory();
            session = configMap;
            return session;
        }

        public static ISession OpenSession() {
            return CreateSession().OpenSession();
        }
    }
}
