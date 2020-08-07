#region Usings
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Repository.Container;
using TheSharpFactory.Repository.Container.Interfaces;
#endregion

namespace TheSharpFactory.Web
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;
        private static string _logDir = "C:\\Logs";

        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Register the model connection string. One per model in the model container
            Database.RegisterModelConnectionString(RepoLookup.ModelId.MainDb, Configuration.GetConnectionString("ChinookContext"));

            //Inject the Repository created by The Sharp Factory
            services.AddSingleton<IRepositoryContainer, RepositoryContainer>();

            if (_env.IsDevelopment())
            {
                //setup logging
                //this will write the SQL Queries to a file or other media
                Database.LogEnabled = false;
                /*                 
                 *  WriteLog is a function defined by the developer to write the log
                 *  to the destination of his/her choosing                 
                 */
                Database.Logger = WriteLog;
            }

            //add controllers and configure json
            var mvcBuilder = services.AddControllersWithViews();

            mvcBuilder.AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });

            mvcBuilder.AddNewtonsoftJson(settings => ConfigureJsonOptions(settings.SerializerSettings))
                .AddJsonOptions(jsonOptions =>
                {
                    jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;//swagger seems off without this line
                    jsonOptions.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
                });

            // When develpment, add following to allow pages are refreshed when views are changed
            if (_env.IsDevelopment())
            {
                mvcBuilder.AddRazorRuntimeCompilation();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static void ConfigureJsonOptions(JsonSerializerSettings settings)
        {
            settings.ContractResolver = new DefaultContractResolver();
            settings.Formatting = Formatting.None;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
        }

        /// <summary>
        /// This is function is used to log SQL Queries produced by The Sharp Factory at runtime
        /// </summary>
        /// <param name="table">The name of the database table or artifact.</param>
        /// <param name="query">The SQL Query as a string.</param>
        private void WriteLog(string table, string query)
        {
            var b = new StringBuilder();
            var now = DateTime.Now;
            b.AppendLine($"DateTime: {now.ToShortDateString()} {now.ToShortTimeString()}");
            b.AppendLine(query);
            b.AppendLine();
            File.AppendAllText(Path.Combine(_logDir, table + "_" + Thread.CurrentThread.ManagedThreadId.ToString() + ".txt"), b.ToString());
        }
    }
}
