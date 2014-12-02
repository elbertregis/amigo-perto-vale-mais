﻿using Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;

namespace APVM
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801


    public class MvcApplication : System.Web.HttpApplication
    {

        private static object _initializerLock = new object();
        private static bool _isInitialized;

        protected void Application_Start()
        {
            //Database.SetInitializer<Contexto>(new APVMInicializador());

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();


        }

        public class SimpleMembershipInitializer
        {
            public SimpleMembershipInitializer()
            {
                using (var context = new Contexto())

                    if (!WebSecurity.Initialized)
                        WebSecurity.InitializeDatabaseConnection("AmigoPertoValeMais", "Usuario", "UsuarioId", "Nome", autoCreateTables: true);
            }
        }

    }

}