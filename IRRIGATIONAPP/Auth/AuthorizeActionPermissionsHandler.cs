//using ERPAuthAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

namespace IRRIGATIONAPP.Auth
{
    internal class AuthorizeActionPermissionsHandler : AuthorizationHandler<ActionPermissionRequirement>
    {
        public static string program = "acc";
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            ActionPermissionRequirement requirement)
        {

            var mvcContext = context.Resource as AuthorizationFilterContext;
            var descriptor = mvcContext?.ActionDescriptor as ControllerActionDescriptor;
            var myAttr = descriptor.FilterDescriptors.Where(x => x.Filter is DisplayActionName).ToArray();

            if (myAttr.Length == 1)
            {
                if (descriptor != null)
                {
                    var actionName = descriptor.ActionName;
                    var ctrlName = descriptor.ControllerName;

                    if (context.User.IsInRole("admin"))
                    {
                        context.Succeed(requirement);
                    }
                    else if (context.User.HasClaim(ActionPermissionConstants.ClaimType, program + "_" + ctrlName + "_" + actionName))
                    {
                        context.Succeed(requirement);
                    }
                }
            }
            else
            { context.Succeed(requirement); }

            return Task.CompletedTask;
        }
    }

    public class ActionPermissionRequirement : IAuthorizationRequirement
    {
        public ActionPermissionRequirement(/*string permissionName*/)
        {
            //ActionPermissionName = permissionName ?? throw new ArgumentNullException(nameof(permissionName));
        }

        //public string ActionPermissionName { get; }
    }



    public static class ActionPermissionConstants
    {
        public const string ClaimType = "ActionPermissions";

    }
    public class Granted : ActionFilterAttribute
    {
        public void OnException(ExceptionContext context)
        {
        }

    }
    public class DisplayActionName : ActionFilterAttribute
    {
        public string DisplayName { get; set; }

    }

}
