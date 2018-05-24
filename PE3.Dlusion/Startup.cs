using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PE3.Dlusion.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PE3.Dlusion
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        //IConfiguration configuration = null;
        //Deze regel herleid je configuratie naar null, en daardoor kan dotnet je configuratie niet vinden uiteraard. Ik voegde hierboven toe wat er tekort stond.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DlusionDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DlusionDb")));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Default}/{action=HomePage}");
            });
        }
    }
}
