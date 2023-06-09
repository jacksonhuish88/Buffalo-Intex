using Buffalo_Intex.Controllers;
using Buffalo_Intex.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.ML.OnnxRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buffalo_Intex
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }   

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.Configure<IdentityOptions>(options =>
            {
                // Makes Password require 3 Unique characters and 12 totalcharacters
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 12;
                options.Password.RequiredUniqueChars = 3;
            });

            services.AddSingleton<Microsoft.ML.OnnxRuntime.InferenceSession>(
                new Microsoft.ML.OnnxRuntime.InferenceSession("wwwroot/decisiontreemod.onnx"));


            services.AddDbContext<postgresContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("MummyDb")));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("MummyDb")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;

                options.MinimumSameSitePolicy = SameSiteMode.None;

            });

            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = "154105035584-6u136ig8d72ebe57iaat36jqip8j5vpt.apps.googleusercontent.com"; //Configuration["Authentication:Google:ClientId"];
                googleOptions.ClientSecret = "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"; // Configuration["Authentication:Google:ClientSecret"];
            });

        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
    
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCookiePolicy();

            // CSP Header
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("Content-Security-Policy", "style-src 'self' 'unsafe-inline'; font-src 'self'; img-src 'self'");
                await next();
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "burialDefault",
                    pattern: "{controller=Burialmains}/{action=Index}/{id?}",
                    defaults: new { Controller = "Burialmains", Action = "Index", pageNum = 1 });

                endpoints.MapRazorPages();
            });

        }
    }
}