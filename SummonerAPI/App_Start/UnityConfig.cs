using SummonerAPI.Services;
using SummonerAPI.Services.Impl;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.WebApi;

namespace SummonerAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterInstance(typeof(HttpConfiguration), GlobalConfiguration.Configuration);
            container.RegisterType<ISummonerService, SummonerService>();
            container.RegisterType<IErrorService, ErrorService>();

            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}