using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClubTreasurer.Models;
using ClubTreasurer.Utilities;
using ClubTreasurer.Interfaces;
using System.Threading.Tasks;
using ClubTreasurer.Data;
using jsreport.AspNetCore;
using jsreport.Local;
using jsreport.Binary;
using AutoMapper;
using System.Globalization;
using Microsoft.Extensions.Options;

namespace ClubTreasurer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-IE");
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.Configure<RCIConfig>(Configuration.GetSection("RCIConfig"));

            services.AddTransient<IEmailSender, AuthMessageSender>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddJsReport(new LocalReporting()
                    .UseBinary(JsReportBinary.GetBinary())
                    .AsUtility()
                    .Create());

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<ClubTreasurerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("LocalDBClubTreasurerContext")));

            services.AddIdentity<AppUser, AppRole>(
                    options => options.Stores.MaxLengthForKeys = 128)
                    .AddEntityFrameworkStores<ClubTreasurerContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();

            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ClubTreasurerContext context,
            RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, IOptions<RCIConfig> rciConfig)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            IdentitySeed.Initialize(context, userManager, rciConfig, roleManager, Configuration).Wait();

            //TODO: Delete after deployment
            //if (env.IsDevelopment())
            //{
            //    app.Use(async (httpContext, next) =>
            //    {
            //        var user = httpContext.User.Identity.Name;
            //        DeveloperLogin(httpContext).Wait();
            //        await next.Invoke();
            //    });
            //}

            app.UseMvc();
        }

        private async Task DeveloperLogin(HttpContext httpContext)
        {

            var UserManager = httpContext.RequestServices.GetRequiredService<UserManager<AppUser>>();
            var signInManager = httpContext.RequestServices.GetRequiredService<SignInManager<AppUser>>();

            var passwords = Configuration.GetSection("Passwords");
            var adminPassword = passwords.GetValue<string>("AdminPassword");
            var result = await signInManager.PasswordSignInAsync("roryaherne@gmail.com", adminPassword, true, lockoutOnFailure: false);
            return;
        }
    }
}
