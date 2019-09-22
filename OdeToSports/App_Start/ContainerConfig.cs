using Autofac;
using Autofac.Integration.Mvc;
using OdeToSports.Data.Models;
using OdeToSports.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToSports.Web
{
    public class ContainerConfig
    {
        // What are the services you want injected? 
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryBaseballData>()
                   .As<IBaseballData>()
                   .SingleInstance();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));


                   

        }
    }
}