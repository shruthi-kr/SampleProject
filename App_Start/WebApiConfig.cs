using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;

namespace LoginProject
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            // filters
            //config.Filters.Add(new NullResponseIs404Attribute());
            //config.Filters.Add(new FakeApiResponseFilter());

            // exception logging - this code is probably unnecessary as Ninject wires this up for us
            //var exceptionLogger = (IExceptionLogger)DependencyResolver.Current.GetService(typeof(IExceptionLogger));
            //config.Services.Add(typeof(IExceptionLogger), exceptionLogger);
            // Content-Negotation Config
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("format", "json", JsonMediaTypeFormatter.DefaultMediaType)
                );
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
                new QueryStringMapping("format", "xml", XmlMediaTypeFormatter.DefaultMediaType)
                );

            config.Formatters.JsonFormatter
            .SerializerSettings
            .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //SetDefaultJsonSerializerSettings();
        }

        private static void SetDefaultJsonSerializerSettings()
        {
            JsonSerializerSettings jSettings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind,
                Converters = new JsonConverter[] { new StringEnumConverter() }
            };

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings = jSettings;
        }
    }
}


