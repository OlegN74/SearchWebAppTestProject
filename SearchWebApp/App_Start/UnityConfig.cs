using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Web.Mvc;
using SearchEngine.Contract;
using Unity.Mvc5;

namespace SearchWebApp
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.LoadConfiguration();
            container.AddNewExtension<UnityLog4NetExtension.Log4Net.Log4NetExtension>();
        }
    }
}