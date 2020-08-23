//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.Extensions.DependencyInjection;
//using QUALIFYDLL.Models;
//using System;
//using System.Linq;
//using System.Threading.Tasks;

//namespace QUALIFYAPP.Auth
//{
//    internal class ApiUserDBTokenHandler : AuthorizationHandler<ApiUserDBTokenRequirement>
//    {
//        private readonly IServiceProvider _serviceProvider;

//        public ApiUserDBTokenHandler(IServiceProvider serviceProvider)
//        {
//            _serviceProvider = serviceProvider;
//        }

//        // Check whether a given MinimumAgeRequirement is satisfied or not for a particular context
//        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ApiUserDBTokenRequirement requirement)
//        {
//            // Check the user's token
//            var authContext = (AuthorizationFilterContext)context.Resource;
//            string token = authContext.HttpContext.Request.Headers["Token"].FirstOrDefault();

//            if (!string.IsNullOrEmpty(token))
//            {
//                using (var scope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
//                {
//                    var db = scope.ServiceProvider.GetRequiredService<AppDBContext>();


//                    var userToken = db.UserApiTokens.Find(token);

//                    if (userToken == null)
//                    {
//                        authContext.HttpContext.Response.StatusCode = 401;
//                        return new JsonResult(new { error = "Invalid_Token" }).ExecuteResultAsync(authContext);
//                    }
//                    else
//                    {
//                        context.Succeed(requirement);
//                    }
//                }
//            }

//            return Task.CompletedTask;
//        }
//    }
//}
