using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.WebEncoders;
using IRRIGATIONAPP.Auth;
using Newtonsoft.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Tokens;
using IRRIGATIONDLL.Models;

namespace IRRIGATIONAPP
{

    public class Startup
    {
        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; // todo: get this from somewhere secure
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            // Adds data protection services
            //try this comment
            services.AddDataProtection();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;

            });


            services.AddDbContext<AppDBContext>(options =>
                options.UseOracle(
                    Configuration.GetConnectionString("DefaultConnection")
                    , b =>
b.UseOracleSQLCompatibility("11")));//.MigrationsAssembly("IRRIGATIONAPP")

            /*services.AddDbContext<mgtDBContext>(options =>
                options.UseOracle(
                    Configuration.GetConnectionString("MGTConnection")
                    , b =>
 b.UseOracleSQLCompatibility("11")));*/
            //MigrationsAssembly("IRRIGATIONAPP").
            //.UseOracle(connection_string, options => options
            //.UseOracleSQLCompatibility("11"))



            //services.AddSingleton<IJwtFactory, JwtFactory>();


            // policy names (instead of using the default policy provider)
            //services.AddSingleton<IAuthorizationPolicyProvider, ApiUserDBTokenPolicyProvider>();

            // As always, handlers must be provided for the requirements of the authorization policies
            //services.AddSingleton<IAuthorizationHandler, ApiUserDBTokenHandler>();

            services.AddScoped<AppDBContext>();

            services.TryAddTransient<IHttpContextAccessor, HttpContextAccessor>();
            /*services.AddAuthentication(options =>
            {
                //options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                //options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = "ApiUser";
                options.DefaultChallengeScheme = "ApiUser";

            }).AddApiAuth(options => { });*/

            // add identity
            //var builder = services.AddIdentityCore<AppUser>(o =>
            //{
            //    // configure identity options
            //    o.Password.RequireDigit = false;
            //    o.Password.RequireLowercase = false;
            //    o.Password.RequireUppercase = false;
            //    o.Password.RequireNonAlphanumeric = false;
            //    o.Password.RequiredLength = 6;
            //});
            //builder = new IdentityBuilder(builder.UserType, typeof(AppRole), builder.Services);
            //builder.AddRoleManager<RoleManager<AppRole>>()
            //       .AddSignInManager<SignInManager<AppUser>>()
            //       .AddEntityFrameworkStores<AppDBContext>()
            //       .AddDefaultTokenProviders();
            //add the following line of code
            //services.AddScoped<IUserClaimsPrincipalFactory<AppUser>, MyUserClaimsPrincipalFactory>();

            // Add application services.
            //services.AddTransient<IEmailSender, EmailSender>();

            services.AddSession();

            services.AddCors();

            services.AddMvc(option =>
            {
                //var policy = new AuthorizationPolicyBuilder()
                //.RequireAuthenticatedUser()
                //.Build();
                //option.Filters.Add(new AuthorizeFilter(policy));

            })
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                //.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddSessionStateTempDataProvider();

            //services.AddAutoMapper();
            //services.AddMvc()/*.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>())*/;

            services.AddAuthorization(a =>
            {
                a.AddPolicy("ActionPermission", policy => policy.AddRequirements(new ActionPermissionRequirement()));
            });
            services.AddSingleton<IAuthorizationHandler, AuthorizeActionPermissionsHandler>();
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            //add swagger

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("MR", new OpenApiInfo { Title = "My API", Version = "v1" });
            //});

            // Swagger - Enable this line and the related lines in Configure method to enable swagger UI
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "IRRIGATION API", Version = "v1" });
                //options.DocInclusionPredicate((docName, description) => true);

                // Define the BearerAuth scheme that's in use

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseExceptionHandler(
                builder =>
                {
                    builder.Run(
                            async context =>
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                                var error = context.Features.Get<IExceptionHandlerFeature>();
                                if (error != null)
                                {
                                    //context.Response.AddApplicationError(error.Error.Message);
                                    await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                                }
                            });
                });
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
            //app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

            });

            //swagger config
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui assets (HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/Swagger/v1/swagger.json", "BlueCherri API V1");
                //  options.RoutePrefix = string.Empty;

            }); // URL: /swagger

            //app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }    
}
