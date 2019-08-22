using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Portal.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "italy",
                    template: "اخذ-اقامت-ایتالیا", new
                    {
                        controller = "Countries",
                        action = "Italy"
                    });
                routes.MapRoute(
                    name: "italy",
                    template: "اخذ-اقامت-پرتغال", new
                    {
                        controller = "Countries",
                        action = "Portugal"
                    });
                routes.MapRoute(
                    name: "italy",
                    template: "اخذ-اقامت-اسلوونی", new
                    {
                        controller = "Countries",
                        action = "Slovenia"
                    });

                routes.MapRoute(
                    name: "italy2",
                    template: "italy", new
                    {
                        controller = "Redirect",
                        action = "Italy"
                    });

                routes.MapRoute(
                   name: "slovenia2",
                   template: "slovenia", new
                   {
                       controller = "Redirect",
                       action = "Slovenia"
                   });

                routes.MapRoute(
                  name: "portugal2",
                  template: "portugal", new
                  {
                      controller = "Redirect",
                      action = "Portugal"
                  });

                routes.MapRoute(
                 name: "about",
                 template: "درباره-ما", new
                 {
                     controller = "Home",
                     action = "AboutUs"
                 });


                routes.MapRoute(
                 name: "about2",
                 template: "about-us", new
                 {
                     controller = "Redirect",
                     action = "AboutUs"
                 });



                routes.MapRoute(
                 name: "contact",
                 template: "تماس-با-ما", new
                 {
                     controller = "Home",
                     action = "ContactUs"
                 });

                routes.MapRoute(
                 name: "contact2",
                 template: "contact-us", new
                 {
                     controller = "Redirect",
                     action = "ContactUs"
                 });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
