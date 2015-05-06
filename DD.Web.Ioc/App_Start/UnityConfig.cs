using System;
using System.Configuration;
using System.Web.Http;
using DD.Mappers;
using DD.Mappers.Common.Interfaces;
using DD.Repositories.Context;
using DD.Repositories.Interfaces.Context;
using DD.Repositories.Interfaces.UnitOfWork;
using DD.Repositories.UnitOfWork;
using DD.Services.Common;
using DD.Services.Interfaces.Common;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace DD.Web.Ioc.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            var connectionString = ConfigurationManager.ConnectionStrings["DiabeticDiary"].ConnectionString;

            container.RegisterType<IDapperContext, DapperContext>(new InjectionConstructor(connectionString));
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerRequestLifetimeManager());

            container.RegisterType<IPersonRecordService, PersonRecordService>();


            container.RegisterType<IMapper, Mapper>();
        }
    }
}
