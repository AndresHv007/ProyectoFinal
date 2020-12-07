using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using CalificacionesContext;
using CalificacionesContext.Models;

using System.IO;
using Microsoft.EntityFrameworkCore;

namespace CalificacionesWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSession();

            string path = "../Database/Calificaciones.db";
            services.AddDbContext<Calificaciones>(options => 
            options.UseSqlite($"Data Source= {path}"));
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
                app.UseHsts();
            }

            app.UseRouting();

            //Security
            app.UseHttpsRedirection();

            //index, default, etc
            app.UseDefaultFiles();

            //use html files
            app.UseStaticFiles();

            //Session init
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
