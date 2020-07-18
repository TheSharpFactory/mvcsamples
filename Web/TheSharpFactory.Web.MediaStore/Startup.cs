#region Usings
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.IO;
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
        private static bool _isDev = false;
        private static string _logDir = "C:\\Logs"
            ;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _isDev = env.IsDevelopment();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //register the model connection string.  one per model in the model container
            Database.RegisterModelConnectionString(RepoLookup.ModelId.MainDb, "Data Source=SHARPFACTORY2;Initial Catalog=Chinook;Integrated Security=true;Application Name=MediaStoreApi");

            //Inject the Repository created by The Sharp Factory
            services.AddSingleton<IRepositoryContainer, RepositoryContainer>();

            if(_isDev)
            {
                //setup logging
                //this will write the SQL Queries to a file or other media
                Database.LogEnabled = true;
                /*                 
                 *  WriteLog is a function defined by the developer to write the log
                 *  to the destination of his/her choosing                 
                 */
                Database.Logger = WriteLog;
            }

            //add controllers and configure json
            services.AddControllersWithViews()
               .AddNewtonsoftJson(settings => ConfigureJsonOptions(settings.SerializerSettings))
               .AddJsonOptions(jsonOptions =>
               {
                   jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null;//swagger seems off without this line
                   jsonOptions.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if(env.IsDevelopment())
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
