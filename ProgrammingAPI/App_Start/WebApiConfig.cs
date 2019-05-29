using Newtonsoft.Json.Serialization;
using ProgrammingAPI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ProgrammingAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Filters.Add(new ApiExceptionAttributes());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;//json a çevrildi
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();//camelcase kucuk buyuk duyarlılık deiştirildi
        }
    }
}
