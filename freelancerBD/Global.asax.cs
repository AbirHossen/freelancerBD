using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using freelancerBD.Infrastructure;
using freelancerBD.Service;
using freelancerBD.IService;
using freelancerBD.Entities;
using Unity;
using Unity.AspNet.Mvc;

namespace freelancerBD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            IUnityContainer container = new UnityContainer();
            
            container.RegisterType<DbContext, FreelancerContext>();
            container.RegisterType<IAdminAction, AdminActionService>();
            container.RegisterType<IAdminService, AdminService>();
            //container.RegisterType<IFReelancerService, FreelancerService>();


            UnityDependencyResolver unityResolver = new UnityDependencyResolver(container);

            DependencyResolver.SetResolver(unityResolver);


            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
