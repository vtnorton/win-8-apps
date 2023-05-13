﻿using AllVtnorton;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Ladon.Repository;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladon
{
    public class FluentySessionFactory
    {
        public static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
            {
                return session;
            }
            else
            {
                IPersistenceConfigurer configDB;
                if(Information.Database == 1)
                {
                    //dev-mode
                    configDB = MsSqlConfiguration.MsSql2012.ConnectionString(c => c.Server(StringConnectionDev.ServerDB).Database(StringConnectionDev.Databese).Username(StringConnectionDev.LoginDB).Password(StringConnectionDev.PassworldDB));

                }
                else
                {
                    //online
                    configDB = MsSqlConfiguration.MsSql2008.ConnectionString(c => c.Server(StringConnection.ServerDB).Database(StringConnection.Databese).Username(StringConnection.LoginDB).Password(StringConnection.PassworldDB));
                }

                var configMap = Fluently.Configure().Database(configDB).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Ladon.Mapping.ApplicationMap>());
                session = configMap.ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none")).BuildSessionFactory();
                return session;
            }
        }

        public static ISession AbriSession()
        {
            return CriarSession().OpenSession();
        }
    }
}