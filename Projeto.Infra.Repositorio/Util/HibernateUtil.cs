using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Projeto.Infra.Repositorio.Mapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Infra.Repositorio.Util
{
    public class HibernateUtil
    {
        //atributo..
        private static ISessionFactory factory; //null

        //método para configurar e retornar a factory em singleton
        public static ISessionFactory Factory
        {
            get
            {
                if(factory == null)
                {
                    factory = Fluently.Configure().Database(
                         MsSqlConfiguration.MsSql2008.ConnectionString(
                         ConfigurationManager.ConnectionStrings["aula"].ConnectionString))
                         .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FuncionarioMap>())
                         .ExposeConfiguration(cfg => new SchemaExport(cfg)
                             .SetOutputFile("c://temp//banco.sql").Create(true, true))
                         .BuildSessionFactory();
                }

                return factory;
            }
        }

    }
}
