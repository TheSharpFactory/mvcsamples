#region Usings
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
#endregion

namespace TheSharpFactory.Web.Swagger
{
    public class SwaggerHelper
    {
        private static string _apiDisplayName = string.Empty;

        private static Dictionary<string, string> _httpMethodDescriptions = new Dictionary<string, string>(4)
        {
            { "GET", "Select" },
            { "POST", "Create" },
            { "PUT", "Update" },
            { "DELETE", "Delete" }
        };

        private readonly static Dictionary<string, int> _httpMethodOrdinals = new Dictionary<string, int>(4)
        {
            { "GET", 1 },
            { "POST", 2 },
            { "PUT", 3 },
            { "DELETE", 4 }
        };

        public static void ConfigureSwaggerGenerationOptions(SwaggerGenOptions c, List<string> xmlFiles, string apiDisplayName)
        {
            _apiDisplayName = apiDisplayName;
            c.SwaggerDoc($"v1.0.0.0", new OpenApiInfo { Title = _apiDisplayName, Version = $"v1.0.0.0" });
            c.CustomSchemaIds(FormatTypeName);
            // Set the comments path for the Swagger JSON and UI.

            foreach(var xmlFile in xmlFiles)
            {
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            }

            c.DocumentFilter<SwaggerExcludeModelFilter>();
            c.SchemaFilter<SwaggerExcludePropertyFilter>();
            c.TagActionsBy(api => GenerateOperationTags(api));
            //c.OrderActionsBy(api => SwaggerHelper.GenerateOperationSortKey(api));
        }


        public static void ConfigureSwaggerUIOptions(SwaggerUIOptions c)
        {
            c.SwaggerEndpoint($"/swagger/v1.0.0.0/swagger.json", $"{_apiDisplayName} v1.0.0.0");
            c.RoutePrefix = string.Empty;

            //c.EnableDeepLinking();
            c.IndexStream = () => typeof(SwaggerHelper).GetTypeInfo().Assembly.GetManifestResourceStream("TheSharpFactory.Web.Swagger.Views.Index.html");
        }

        private static List<string> GenerateOperationTags(ApiDescription api)
        {
            var httpMethodDesc = string.Empty;
            if(_httpMethodDescriptions.ContainsKey(api.HttpMethod))
                httpMethodDesc = _httpMethodDescriptions[api.HttpMethod];
            else
                httpMethodDesc = api.HttpMethod;

            var routeInfo = (from r in api.ActionDescriptor.EndpointMetadata where r is Microsoft.AspNetCore.Mvc.RouteAttribute select r as Microsoft.AspNetCore.Mvc.RouteAttribute).FirstOrDefault();
            var operationTag = string.Empty;
            if(string.IsNullOrWhiteSpace(routeInfo?.Template))
            {
                operationTag = api.ActionDescriptor.RouteValues["controller"];
            }
            else
            {
                var cleanTemplate = routeInfo.Template.Replace("api/", "");
                var routes = cleanTemplate.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                if(routes.Length > 2)
                {
                    operationTag = $"{routes[0]} - {routes[1]}";
                }
                else
                {
                    operationTag = api.ActionDescriptor.RouteValues["controller"];
                }
            }

            return new List<string> { operationTag };
        }

        private static string FormatTypeName(Type type)
        {
            var rootType = type.IsGenericType
               ? type.GetGenericTypeDefinition()
               : type;

            var cleanedName = rootType.Name;
            if(rootType.Namespace.StartsWith("System", StringComparison.Ordinal) || rootType.Namespace.StartsWith("Microsoft", StringComparison.Ordinal))
                cleanedName = rootType.ToString();

            //var cleanedName = rootType.IsPrimitive
            //                     ? rootType.Name
            //                     : rootType.ToString();

            if(!type.IsGenericType)
                return cleanedName;
            else
                return cleanedName.Substring(0, cleanedName.LastIndexOf('`'))
                    + type.GetGenericArguments().Aggregate("<",
                                        (r, i) =>
                                           r
                                           + (r != "<" ? ", " : null)
                                           + FormatTypeName(i))
                                           + ">";

        }
    }

    public class SwaggerExcludeModelFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument doc, DocumentFilterContext context)
        {
            if(doc?.Components?.Schemas == null || context == null)
                return;

            var excludeModels = new[] { "IntPtr" };

            //remove all types that do not belong to the root namespace of the solution
            var typeNames = doc.Components.Schemas.Keys.ToList();

            foreach(var t in typeNames)
            {
                if(t.StartsWith("System", StringComparison.Ordinal) || t.StartsWith("Microsoft", StringComparison.Ordinal))
                    doc.Components.Schemas.Remove(t);
            }

            //remove primtive types that are left over
            foreach(var model in excludeModels)
                if(doc.Components.Schemas.ContainsKey(model))
                    doc.Components.Schemas.Remove(model);

            var cleanTypes = new List<KeyValuePair<string, OpenApiSchema>>(doc.Components.Schemas.Count);

            var dataExchangeResultTypes = new List<KeyValuePair<string, OpenApiSchema>>(doc.Components.Schemas.Count);
            var otherTypes = new List<KeyValuePair<string, OpenApiSchema>>(doc.Components.Schemas.Count);

            var rawDefinitions = doc.Components.Schemas.ToList();

            foreach(var def in rawDefinitions)
            {
                if(def.Key.Contains("DataResult", StringComparison.Ordinal) || def.Key.Contains("DataExchangeResult", StringComparison.Ordinal))
                    dataExchangeResultTypes.Add(def);
                else
                    otherTypes.Add(def);
            }

            dataExchangeResultTypes = dataExchangeResultTypes.OrderBy(def => def.Key).ToList();
            otherTypes = otherTypes.OrderBy(def => def.Key).ToList();

            doc.Components.Schemas.Clear();

            foreach(var def in dataExchangeResultTypes)
            {
                doc.Components.Schemas.Add(def.Key, def.Value);
            }

            foreach(var def in otherTypes)
            {
                doc.Components.Schemas.Add(def.Key, def.Value);
            }

            //make operations ordered by http method      
            //var paths = doc.Paths.OrderBy(e => e.Key).ToList();
            //doc.Paths = paths.ToDictionary(e => e.Key, e => e.Value);
        }
    }
    public class SwaggerExcludePropertyFilter : ISchemaFilter
    {
        #region ISchemaFilter Members

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if(schema?.Properties == null || context == null)
                return;

            var excludeProperties = new[] { "Exception" };

            foreach(var prop in excludeProperties)
                if(schema.Properties.ContainsKey(prop))
                    schema.Properties.Remove(prop);
        }

        #endregion
    }
}
