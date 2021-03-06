﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using RiaLibrary.Web;

namespace ojuaraloc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoutes(); 

            routes.MapRoute(
                name: "Master",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Titulo", action = "Inicio", id = UrlParameter.Optional }
            );
        }
    }
}