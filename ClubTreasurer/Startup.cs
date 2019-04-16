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
using Microsoft.AspNetCore.Localization;
using ClubTreasurer.Data;

namespace ClubTreasurer
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

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, AuthMessageSender>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddDbContext<ClubTreasurerContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("ClubTreasurerContext")));

            services.AddIdentity<AppUser, AppRole>(
                    options => options.Stores.MaxLengthForKeys = 128)
                    .AddEntityFrameworkStores<ClubTreasurerContext>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();
            }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ClubTreasurerContext context, 
            RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
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

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en-IE")
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            IdentitySeed.Initialize(context, userManager, roleManager, Configuration).Wait();

            //TODO: Delete after deployment
            if (env.IsDevelopment())
            {
                app.Use(async (httpContext, next) =>
                {
                    var user = httpContext.User.Identity.Name;
                    DeveloperLogin(httpContext).Wait();
                    await next.Invoke();
                });
            }

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
