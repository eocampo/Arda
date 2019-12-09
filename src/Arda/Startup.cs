using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Arda.Models;
using Arda.Data;

namespace Arda
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, ApplicationRole>(options => {
            }).AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddIdentity<ApplicationUser, ApplicationRole>(options => {
            //    // ...
            //}).AddEntityFrameworkStores<ApplicationDbContext, int>(); // NOTE this line

            //services.AddTransient<ICharacterRepository, EFCharacterRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            //if (env.IsDevelopment()) {
            //    app.UseDeveloperExceptionPage();
            //}

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            //app.UseAuthentication();

            app.UseMvcWithDefaultRoute();
        }
    }
}
