using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ProgettoEsame.Models;

namespace ProgettoEsame
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddDbContext<ContosoContext>(options => options.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Contoso; Integrated Security = True; Connect Timeout = 30;"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
         

            //app.UseMvcWithDefaultRoute(); questo fa puntare al home controller

            app.UseMvc(
                 routes =>
                 {
                     routes
                     .MapRoute("Default", "{controller=Home}/{action=IndexWithForm}/{id?}")
                    // .MapRoute("Default", "{controller=Home}/{action=Index}/{id?}")
                     .MapRoute("Members", "Members/{controller=MemberHome}/{action=Index}/{id?}");
                 }
           );

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello Andreaxt!");
            });
        }
    }
}
