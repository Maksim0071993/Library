using Autofac;
using AutoMapper;
using Library.BusinessLogicLayer.Interfaces;
using Library.BusinessLogicLayer.Services;
using Library.DataAccessLayer;
using Library.DataAccessLayer.Interfaces;
using Library.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Hosting;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Library
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<BookRepository>().As<IBookRepository>();
            containerBuilder.RegisterType<AuthorRepository>().As<IAuthorRepository>();
            containerBuilder.RegisterType<BookService>().As<IBookService>();
            containerBuilder.RegisterType<AuthorService>().As<IAuthorService>();
            containerBuilder.RegisterType<LibraryEntities>().As<LibraryEntities>();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/AllBooks.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/Search.aspx"));
            var container = containerBuilder.Build();
            var autofacAdapter = new AutofacAdapter(container);
            HttpRuntime.WebObjectActivator = autofacAdapter;
            HostingEnvironment.RegisterObject(autofacAdapter);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}