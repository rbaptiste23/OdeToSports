using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OdeToSports.Data.Models;
using OdeToSports.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OdeToSports.Web
{
    public class ContainerConfig
    {
        // What are the services you want injected? 
        internal static void RegisterContainer(HttpConfiguration httpConfiguration)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);


            builder.RegisterType<SqlBaseballData>()
                   .As<IBaseballData>()
                   .InstancePerRequest();


            builder.RegisterType<OdeToSportsDbContext>().InstancePerRequest();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            httpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}