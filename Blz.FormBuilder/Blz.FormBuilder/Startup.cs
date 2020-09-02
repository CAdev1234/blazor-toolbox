using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Blz.FormBuilder.Data;
using Blz.FormBuilder.Services;
using Blz.FormBuilder.Controls;
using Blz.FormBuilder.Context;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.SessionStorage;

namespace Blz.FormBuilder
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IEditableControlProperty>();

            services.AddSingleton<HttpClient>();
            services.AddSingleton<AppSettingsService>();
            services.AddSingleton<DAL>();

            services.AddHttpContextAccessor();

            services.AddServerSideBlazor().AddCircuitOptions(o => o.DetailedErrors = true);

            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddBlazoredSessionStorage();

            // Google auth service added
            //services.AddAuthentication().AddGoogle(googleOptions =>
            //{
                //googleOptions.ClientId = "Authentication:Google:ClientId";
                ///googleOptions.ClientSecret = "Authentication:Google:ClientSecret";
            //});
            // Facebook auth service added
            //services.AddAuthentication().AddFacebook(facebookOptions =>
            //{
                //facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                //facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];

                //facebookOptions.Events = new Microsoft.AspNetCore.Authentication.OAuth.OAuthEvents()
                //{
                    //OnRemoteFailure = LoginFail
                //};
            //});
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");

            });
        }
    }
}
