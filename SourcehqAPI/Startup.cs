using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SourcehqAPI.ConfigurationContext;

namespace SourcehqAPI
{
    public class Startup
    {
        private const string SettingsFile = "appsettings.json";
        private const string SourceHQDatabaseConnectionStringKey = "SourcehqData";
        private const string UtilityDatabaseConnectionStringKey = "Utility";

        public IConfiguration _configuration;
        //public IConfigurationContext _configurationContext;

        public Startup(IWebHostEnvironment webHostEnvironment)
        {
            _configuration = BuildConfiguration(webHostEnvironment);
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public static IConfiguration BuildConfiguration(IWebHostEnvironment webHostEnvironment)
        {
            IConfigurationBuilder builder;

            if(webHostEnvironment.IsDevelopment())
            {
                builder = new ConfigurationBuilder()
                    .SetBasePath(webHostEnvironment.ContentRootPath)
                    .AddJsonFile(SettingsFile, optional: true, reloadOnChange: true)
                    .AddJsonFile(GetEnvironmentSettingsFileName(webHostEnvironment.EnvironmentName), optional: true)
                    .AddEnvironmentVariables()
                    .AddUserSecrets<Program>();
            }
            else
            {
                builder = new ConfigurationBuilder().AddJsonStream(new MemoryStream());
            }

            return builder.Build();
        }

        //public static IConfigurationContext BuildConfigurationContext(IConfuguration configuration)
        //{
            //IConfiguration configurationContext = new ConfigurationContext(configuration);
        //}

        public static string GetEnvironmentSettingsFileName(string environment)
        {
            return SettingsFile.Replace(".", $".{environment}.");
        }


    }
}
