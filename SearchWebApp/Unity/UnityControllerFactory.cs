using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;

namespace SearchWebApp.Unity
{
    public class UnityControllerFactory : DefaultControllerFactory
    {
        private readonly IUnityContainer container;

        public UnityControllerFactory(IUnityContainer container)
        {
            this.container = container;
        }

        protected IController GetControllerInstance(Type controllerType)
        {
            return container.Resolve(controllerType) as IController;
        }
    }
}