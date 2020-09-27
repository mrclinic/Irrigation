using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IRRIGATION.API;
using IRRIGATIONDLL.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IRRIGATION.Controllers
{
    public class GOVERNORATEController : ApiControllerBase
    {
        public GOVERNORATEController(AppDBContext _db) : base(_db) { }
         public IActionResult Index()
        {
            return View();
        }
           public ActionResult GOVERNORATE_Read([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                IQueryable<GOVERNORATE> _GOVERNORATE = db.GOVERNORATE.AsQueryable();

                DataSourceResult result = _GOVERNORATE.ToDataSourceResult(request, governorate => new
                {
                    Id = governorate.Id,
                    CREATION_DATE = governorate.CREATION_DATE,
                    CREATE_USERNB = governorate.CREATE_USERNB,
                    UPDATE_DATE = governorate.UPDATE_DATE,
                    UPDATE_USERNB = governorate.UPDATE_USERNB,
                    NAME = governorate.NAME,
                    ORDER = governorate.ORDER,
                    NOTE = governorate.NOTE,

                });
                return Json(result);
            }
            catch (Exception e)
            {
                return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
            }
        }
           public ActionResult GOVERNORATE_Create([DataSourceRequest] DataSourceRequest request, GOVERNORATE governorate)
        {
            if (ModelState.IsValid)
            {
                var entity = new GOVERNORATE
                {
                    Id = governorate.Id,
                    CREATION_DATE = governorate.CREATION_DATE,
                    CREATE_USERNB = governorate.CREATE_USERNB,
                    UPDATE_DATE = governorate.UPDATE_DATE,
                    UPDATE_USERNB = governorate.UPDATE_USERNB,
                    NAME = governorate.NAME,
                    ORDER = governorate.ORDER,
                    NOTE = governorate.NOTE,

                };
                try
                {
                    db.GOVERNORATE.Add(entity);
                    db.SaveChanges();
                    governorate.Id = entity.Id;
                }
                catch (Exception e)
                {
                    return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
                }
            }

            return Json(new[] { governorate }.ToDataSourceResult(request, ModelState));
        }
           public ActionResult GOVERNORATE_Update([DataSourceRequest] DataSourceRequest request, GOVERNORATE governorate)
        {
            if (ModelState.IsValid)
            {
                var entity = new GOVERNORATE
                {
                    Id = governorate.Id,
                    CREATION_DATE = governorate.CREATION_DATE,
                    CREATE_USERNB = governorate.CREATE_USERNB,
                    UPDATE_DATE = governorate.UPDATE_DATE,
                    UPDATE_USERNB = governorate.UPDATE_USERNB,
                    NAME = governorate.NAME,
                    ORDER = governorate.ORDER,
                    NOTE = governorate.NOTE,

                };
                try
                {
                    db.GOVERNORATE.Attach(entity);
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
                }
            }

            return Json(new[] { governorate }.ToDataSourceResult(request, ModelState));
        }
         public ActionResult GOVERNORATE_Destroy([DataSourceRequest] DataSourceRequest request, GOVERNORATE governorate)
        {
            if (ModelState.IsValid)
            {
                var entity = new GOVERNORATE
                {
                    Id = governorate.Id,
                    CREATION_DATE = governorate.CREATION_DATE,
                    CREATE_USERNB = governorate.CREATE_USERNB,
                    UPDATE_DATE = governorate.UPDATE_DATE,
                    UPDATE_USERNB = governorate.UPDATE_USERNB,
                    NAME = governorate.NAME,
                    ORDER = governorate.ORDER,
                    NOTE = governorate.NOTE,

                };
                try
                {
                    db.Remove(entity);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
                }
            }

            return Json(new[] { governorate }.ToDataSourceResult(request, ModelState));
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
