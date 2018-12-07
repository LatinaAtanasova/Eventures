using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Eventures.Web.Filters;
using Eventures.Web.Logging.LoggerFactoryExtensions;
using Eventures.Web.Middlewares.MiddlewareExtensions;
using Eventures.Web.Utilities;
using Eventures.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Eventures.Web
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

            services.AddDbContext<EventuresDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<EventuresUser, IdentityRole>(opt =>
                {
                    opt.SignIn.RequireConfirmedEmail = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequiredUniqueChars = 0;
                    opt.Password.RequiredLength = 3;
                })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<EventuresDbContext>();

            

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Accounts/Login";
                options.LogoutPath = $"/Identity/Accounts/Logout";
                options.AccessDeniedPath = $"/Accounts/AccessDenied";
            });

            services.AddMvc(
                options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute()); 

                }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IEventureEventService, EventureEventService>();
            services.AddScoped<IEventureOrderService, EventureOrderService>();
            services.AddScoped<LogUserActivityActionFilter>();
            services.AddLogging();
            services.AddAuthentication()
                .AddFacebook(facebookOptions =>
                {
                    facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                    facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                });
            services.AddAutoMapper(config =>
            {
                config.CreateMap<RegisterViewModel, EventuresUser>()
                    // в случаите, когато пропъртитата не са едни и същи //
                    .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Username)); 

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            IServiceProvider serviceProvider,
            ILoggerFactory loggingFactory,
            EventuresDbContext dbContext)
        {
            loggingFactory.AddContext(LogLevel.Error, dbContext);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            //Seeder.Seed(serviceProvider);
            app.UseSeedDataMiddleWare();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();


            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}"
                );
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
