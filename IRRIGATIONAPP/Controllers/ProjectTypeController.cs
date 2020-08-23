//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Kendo.Mvc.Extensions;
//using Kendo.Mvc.UI;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using QUALIFYAPP.API;
//using QUALIFYDLL.Models;

//namespace QUALIFYAPP.Controllers
//{
//    //[Area("Accounting")]
//    //[Authorize(Policy = "ActionPermission")]
//    public class ProjectTypeController :
//        ApiControllerBase
//    {
//        public ProjectTypeController(AppDBContext _db) : base(_db){}

//        public ActionResult Index()
//        {
//            return View();
//        }
//        // [DisplayActionName(DisplayName = "Read All Account Types")]
//        public ActionResult ProjectType_Read([DataSourceRequest]DataSourceRequest request)
//        {
//            try
//            {
//                List<ProjectType> _projectType = db.ProjectType.ToList();
//                DataSourceResult result = _projectType.ToDataSourceResult(request, projectType => new
//                {
//                    Id = projectType.Id,
//                    CODE = projectType.CODE,
//                    NAME = projectType.NAME,
//                    NOTE = projectType.NOTE,
//                    IS_ACTIVE = projectType.IS_ACTIVE,
//                    CREATION_DATE = projectType.CREATION_DATE,
//                    USERNB = projectType.USERNB
//                });

//                return Json(result);
//            }
//            catch (Exception e)
//            {
//                return Json(new
//                {
//                    Data = new[] { String.Empty },
//                    Total = "0",
//                    AggregateResults = "",
//                    Errors = new { msg = new { errors = new[] { e.Message } } }
//                });
//            }
//        }
//        [HttpPost]
//        //[DisplayActionName(DisplayName = "Add New Account Type")]
//        public ActionResult ProjectType_Create([DataSourceRequest]DataSourceRequest request, [FromBody] ProjectType projectType)
//        {
//            if (ModelState.IsValid)
//            {
//                var entity = new ProjectType
//                {
//                    CODE = projectType.CODE,
//                    NAME = projectType.NAME,
//                    NOTE = projectType.NOTE,
//                    IS_ACTIVE = projectType.IS_ACTIVE,
//                    CREATION_DATE = projectType.CREATION_DATE,
//                    USERNB = projectType.USERNB
//                };
//                try
//                {
//                    db.ProjectType.Add(entity);
//                    db.SaveChanges();
//                    projectType.Id = entity.Id;
//                }
//                catch (Exception e)
//                {
//                    return Json(new
//                    {
//                        Data = new[] { String.Empty },
//                        Total = "0",
//                        AggregateResults = "",
//                        Errors = new { msg = new { errors = new[] { e.Message } } }
//                    });
//                }
//            }

//            return Json(new[] { projectType }.ToDataSourceResult(request, ModelState));
//        }

//        [HttpPost]
//        //[DisplayActionName(DisplayName = "Edit Account Type")]
//        public ActionResult ProjectType_Update([DataSourceRequest]DataSourceRequest request, [FromBody] ProjectType projectType)
//        {
//            if (ModelState.IsValid)
//            {
//                var entity = new ProjectType
//                {
//                    Id = projectType.Id,
//                    CODE = projectType.CODE,
//                    NAME = projectType.NAME,
//                    NOTE = projectType.NOTE,
//                    IS_ACTIVE = projectType.IS_ACTIVE,
//                    CREATION_DATE = projectType.CREATION_DATE,
//                    USERNB = projectType.USERNB
//                };
//                try
//                {
//                    db.ProjectType.Attach(entity);
//                    db.Entry(entity).State = EntityState.Modified;
//                    db.SaveChanges();
//                }
//                catch (Exception e)
//                {
//                    return Json(new
//                    {
//                        Data = new[] { String.Empty },
//                        Total = "0",
//                        AggregateResults = "",
//                        Errors = new { msg = new { errors = new[] { e.Message } } }
//                    });
//                }
//            }

//            return Json(new[] { projectType }.ToDataSourceResult(request, ModelState));
//        }

//        [HttpPost]
//        public ActionResult ProjectType_Destroy([DataSourceRequest]DataSourceRequest request, [FromBody] ProjectType projectType)
//        {
//            if (ModelState.IsValid)
//            {
//                var entity = new ProjectType
//                {
//                    Id = projectType.Id,
//                    CODE = projectType.CODE,
//                    NAME = projectType.NAME,
//                    NOTE = projectType.NOTE,
//                    IS_ACTIVE = projectType.IS_ACTIVE,
//                    CREATION_DATE = projectType.CREATION_DATE,
//                    USERNB = projectType.USERNB
//                };

//                //long ss = db.Database.ExecuteSqlCommand(" delete from dbo.ProjectType  where ID = " + projectType.Id);
//                try
//                {
//                    db.Remove(entity);
//                    db.SaveChanges();
//                }
//                catch (Exception e)
//                {
//                    return Json(new
//                    {
//                        Data = new[] { String.Empty },
//                        Total = "0",
//                        AggregateResults = "",
//                        Errors = new { msg = new { errors = new[] { e.Message } } }
//                    });
//                }

//                db.SaveChanges();
//            }

//            return Json(new[] { projectType }.ToDataSourceResult(request, ModelState));
//        }

//        protected override void Dispose(bool disposing)
//        {
//            db.Dispose();
//            base.Dispose(disposing);
//        }
//    }

//}
