//using System.Linq;
//using Microsoft.AspNetCore.Mvc;
////using ERPAuthAPI.Models;
////using ERPAuthAPI.ViewModels;
//using Microsoft.AspNetCore.Mvc.Infrastructure;
//using QUALIFYAPP.Auth;
//using QUALIFYDLL.Models;

//namespace QUALIFYAPP.Controllers
//{
//    public class InstallController : Controller
//    {
//        private readonly IActionDescriptorCollectionProvider _provider;
//        private readonly AppDBContext _db;

//        public InstallController(IActionDescriptorCollectionProvider provider, AppDBContext db)
//        {
//            _provider = provider;
//            _db = db;
//        }

//        public IActionResult ReadRoutes()
//        {

//            var routes = _provider.ActionDescriptors.Items.Select(x => new {
//                Action = x.RouteValues["Action"],
//                Controller = x.RouteValues["Controller"],
//                Area = x.RouteValues["Area"],
//                //Url = x.RouteValues["URL"],
//                //Name = x.AttributeRouteInfo.Name,
//                //Template = x.AttributeRouteInfo.Template
//            }).ToList();

//            return Ok(routes);
//        }

//        public IActionResult UpdatePermissions()
//        {

//            var routes = _provider.ActionDescriptors.Items.Select(x => new {
//                Action = x.RouteValues["Action"],
//                Controller = x.RouteValues["Controller"],
//                Area = x.RouteValues["Area"],
//                grant = x.FilterDescriptors.Where(a => a.Filter is Granted).Any(),
//                Name = x.FilterDescriptors.Where(a => a.Filter is DisplayActionName),
//                Name1 = x.FilterDescriptors.Where(a => a.Filter is DisplayActionName).Any(),
//                //Url = x.RouteValues["URL"],
//                //Name = x.AttributeRouteInfo.Name,
//                //t = x.DisplayName,
//                //t = x.DisplayName ,//!= null ? x.DisplayName : x.RouteValues["Action"],
//                //Template = x.AttributeRouteInfo.Template
//            }).Where(a => a.grant == false && a.Name1 == true).ToList();

//            string program = AuthorizeActionPermissionsHandler.program;

//            //check group
//            var group = _db.PermissionGroups.Where(x => x.Name == program).FirstOrDefault();
//            if (group == null)
//            {
//                _db.PermissionGroups.Add(new PermissionGroup() { Name = program });
//                _db.SaveChanges();
//                group = _db.PermissionGroups.Where(x => x.Name == program).FirstOrDefault();
//            }

//            foreach (var route in routes)
//            {
//                DisplayActionName ttt = (DisplayActionName)route.Name.FirstOrDefault().Filter;
//                string permstr1 = (ttt != null ? ttt.DisplayName : "");
//                string permstr = program + "_" + route.Controller + "_" + route.Action;
//                //find perms
//                var perms = _db.Permissions.Where(x => x.Name == permstr && x.GroupId == group.Id).FirstOrDefault();
//                if (perms == null)
//                {
//                    _db.Permissions.Add(new AppPermission() { Name = permstr, DisplayName = permstr1, GroupId = group.Id });
//                }
//            }

//            _db.SaveChanges();

//            return Ok("updated..");
//        }
//    }
//}
