﻿using System.Web.Mvc;
using System.Web.Routing;

namespace MLSSearch3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("Content/{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
        }
    }
}