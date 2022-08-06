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
            containerBuilder.RegisterType<UserProfileRepository>().As<IUserProfileRepository>();
            containerBuilder.RegisterType<BookService>().As<IBookService>();
            containerBuilder.RegisterType<AuthorService>().As<IAuthorService>();
            containerBuilder.RegisterType<LibraryEntity>().As<LibraryEntity>();
            containerBuilder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            containerBuilder.RegisterType<UserProfileService>().As<IUserProfileService>();
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/AllBooks.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/Search.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/AddBook.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/ResultSearch.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/AddAuthor.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/Account/Register.aspx"));
            containerBuilder.RegisterType(BuildManager.GetCompiledType("/BookAdditionConfirmation.aspx"));
            

            var container = containerBuilder.Build();
            var autofacAdapter = new AutofacAdapter(container);
            HttpRuntime.WebObjectActivator = autofacAdapter;
            HostingEnvironment.RegisterObject(autofacAdapter);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}