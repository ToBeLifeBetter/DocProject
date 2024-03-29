﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ToBeLiftBetter.DOCProject.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "Default",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new string[] { "ToBeLiftBetter.DOCProject.UI.Controllers" }
         );

            routes.MapRoute(
            name: "Back",
            url: "Back/{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },new string[] { "ToBeLiftBetter.DOCProject.UI.Areas.Back.Controllers" }
        );


        }
    }
}
