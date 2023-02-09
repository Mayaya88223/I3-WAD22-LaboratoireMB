using AdopteUnDev_Mariam_COMMON.Repository;
using BLLObj = AdopteUnDev_Mariam_BLL.Entities;
using DALObj = AdopteUnDev_Mariam_DAL.Entities;
using DALServ = AdopteUnDev_Mariam_DAL.Services;
using BLLServ = AdopteUnDev_Mariam_BLL.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdopteUnDev_Mariam
{
    public class Startup
    {
        private readonly string _connectionString;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _connectionString = Configuration.GetConnectionString("DB_AdopteUnDev");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped < IClientRepository<DALObj.Client, int>, DALServ.ClientService>();
            services.AddScoped < IClientRepository <BLLObj.Client, int>, BLLServ.ClientService>();
            services.AddScoped < IDeveloperRepository <DALObj.Developer, int>, DALServ.DeveloperService>();
            services.AddScoped < IDeveloperRepository <BLLObj.Developer, int>, BLLServ.DeveloperService>();
       
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

