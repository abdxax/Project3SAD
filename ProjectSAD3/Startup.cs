using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectSAD3.Data;
using ProjectSAD3.Models;
using ProjectSAD3.Repstory;

namespace ProjectSAD3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option=>option.EnableEndpointRouting=false);
            services.AddDbContext<DContext>(op=>op.UseSqlServer(@"Data Source= LAPTOP-7KTRGKH2\SQLEXPRESS; Integrated Security=true;Initial Catalog=computers; "));
          //  services.AddDbContext<DContext>();
            services.AddScoped<IRepstory<Computer>, RepstoryComputer>();
            services.AddScoped<IRepstory<Order>, RepstoryOrder>();
            //services.AddDbContext<>
            services.AddDistributedMemoryCache();
            services.AddSession();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.UseSession();

            /* app.UseEndpoints(endpoints =>
             {
                 endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello World!");
                 });
             });*/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
