﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Kippenbout.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //TODO: add additional config code.


            //Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                    );

        }
    }
}
