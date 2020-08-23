//using Microsoft.AspNetCore.Authentication;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;
//using Microsoft.Net.Http.Headers;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Security.Principal;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;

//namespace QUALIFYAPP.Auth
//{
//    public class ApiUserDBTokenAuthenticationHandler : AuthenticationHandler<ApiAuthenticationOptions>
//    {
//        private readonly IServiceProvider _serviceProvider;

//        public ApiUserDBTokenAuthenticationHandler(IServiceProvider serviceProvider, IOptionsMonitor<ApiAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
//            : base(options, logger, encoder, clock)
//        {
//            _serviceProvider = serviceProvider;
//        }

//        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
//        {
//            // Get Authorization header value
//            if (!Request.Headers.TryGetValue(HeaderNames.Authorization, out var authorization))
//            {
//                return Task.FromResult(AuthenticateResult.Fail("Cannot read authorization header."));
//            }
//            else
//            {
//                using (var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
//                {
//                    var db = scope.ServiceProvider.GetRequiredService<AppDBContext>();


//                    var userToken = db.UserApiTokens.Include(c => c.User.Roles).Where(c => c.Id == authorization).FirstOrDefault();

//                    if (userToken == null)
//                    {
//                        //return new results("error", null, "your account is locked or suspended or disapproved please check with veryeasycar", "حسابك معطل.. ", -1);
//                        //context.Fail();
//                        //authContext.HttpContext.Response.StatusCode = 401;
//                        //return new JsonResult(new { error = "Invalid_Token" }).ExecuteResultAsync(authContext);
//                        return Task.FromResult(AuthenticateResult.Fail("Invalid_Token"));
//                    }
//                    else
//                    {
//                        var user = userToken.User;
//                        // Create authenticated user
//                        var claims = new List<Claim>();

//                        claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
//                        claims.Add(new Claim(ClaimTypes.Email, user.EMAIL));
//                        claims.Add(new Claim("UserName", user.USERNAME));

//                        foreach (var role in user.Roles)
//                        {
//                            claims.Add(new Claim(ClaimTypes.Role, role.Roles.Name));

//                            foreach (var claim in role.Roles.RoleClaims)
//                            {
//                                claims.Add(new Claim(claim.ClaimType, claim.ClaimValue));
//                            }

//                            foreach (var permission in role.Roles.RolePermissions.Select(x => x.Permissions.Name).ToList())
//                            {
//                                claims.Add(new Claim(ActionPermissionConstants.ClaimType, permission));
//                            }
//                        }

//                        var identities = new List<ClaimsIdentity> { new ClaimsIdentity(new GenericIdentity(user.USERNAME, "Token"), claims) };
//                        var ticket = new AuthenticationTicket(new ClaimsPrincipal(identities), Options.Scheme);

//                        return Task.FromResult(AuthenticateResult.Success(ticket));
//                    }
//                }
//            }

//        }
//    }



//    public class ApiAuthenticationOptions : AuthenticationSchemeOptions
//    {
//        public const string DefaultScheme = "ApiUser";
//        public string Scheme => DefaultScheme;
//        //public StringValues AuthKey { get; set; }
//    }


//    public static class AuthenticationBuilderExtensions
//    {
//        // Custom authentication extension method
//        public static AuthenticationBuilder AddApiAuth(this AuthenticationBuilder builder, Action<ApiAuthenticationOptions> configureOptions)
//        {
//            // Add custom authentication scheme with custom options and custom handler
//            return builder.AddScheme<ApiAuthenticationOptions, ApiUserDBTokenAuthenticationHandler>(ApiAuthenticationOptions.DefaultScheme, configureOptions);
//        }
//    }
//}
