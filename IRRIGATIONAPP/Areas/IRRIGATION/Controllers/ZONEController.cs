using System;
using System.Collections.Generic;
using System.Linq;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IRRIGATIONAPP.API;
using IRRIGATIONDLL.Models;
namespace IRRIGATIONAPP.IRRIGATION.Controllers
{
    [Area("IRRIGATION")]
    [Route("[area]/[controller]")]
    public class ZONEController : ApiControllerBase
    {
        public ZONEController(AppDBContext _db) : base(_db) { }
        [HttpGet("index")]
        public ActionResult Index()
        {
            return View();
        }
        //[DisplayActionName(DisplayName = "Read All ZONEs")]
        [HttpGet("ZONE_Read")]
        public ActionResult ZONE_Read([DataSourceRequest] DataSourceRequest request)
        {
            try
            {
                IQueryable<ZONE> _ZONE = db.ZONE.Include(p => p.GOVERNORATE).AsQueryable();

                DataSourceResult result = _ZONE.ToDataSourceResult(request, zone => new
                {
                    Id = zone.Id,
                    CREATION_DATE = zone.CREATION_DATE,
                    CREATE_USERNB = zone.CREATE_USERNB,
                    UPDATE_DATE = zone.UPDATE_DATE,
                    UPDATE_USERNB = zone.UPDATE_USERNB,
                    NAME = zone.NAME,
                    ORDER = zone.ORDER,
                    NOTE = zone.NOTE,
                    GOVId = zone.GOVId,

                    GOVERNORATE = new GOVERNORATE
                    {
                        NAME = zone.GOVERNORATE?.NAME,
                        ORDER = zone.GOVERNORATE?.ORDER
                    },
                });
                return Json(result);
            }
            catch (Exception e)
            {
                return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
            }
        }
        [HttpPost("ZONE_Create")]
        //[DisplayActionName(DisplayName = "Add New ZONE")]
        public ActionResult ZONE_Create([DataSourceRequest] DataSourceRequest request, [FromBody] ZONE zone)
        {
            if (ModelState.IsValid)
            {
                var entity = new ZONE
                {
                    Id = zone.Id,
                    CREATION_DATE = zone.CREATION_DATE,
                    CREATE_USERNB = zone.CREATE_USERNB,
                    UPDATE_DATE = zone.UPDATE_DATE,
                    UPDATE_USERNB = zone.UPDATE_USERNB,
                    NAME = zone.NAME,
                    ORDER = zone.ORDER,
                    NOTE = zone.NOTE,
                    GOVId = zone.GOVId,

                };
                try
                {
                    db.ZONE.Add(entity);
                    db.SaveChanges();
                    zone.Id = entity.Id;
                }
                catch (Exception e)
                {
                    return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
                }
            }

            return Json(new[] { zone }.ToDataSourceResult(request, ModelState));
        }
        [HttpPost("ZONE_Update")]
        //[DisplayActionName(DisplayName = "Edit ZONE")]
        public ActionResult ZONE_Update([DataSourceRequest] DataSourceRequest request, [FromBody] ZONE zone)
        {
            if (ModelState.IsValid)
            {
                var entity = new ZONE
                {
                    Id = zone.Id,
                    CREATION_DATE = zone.CREATION_DATE,
                    CREATE_USERNB = zone.CREATE_USERNB,
                    UPDATE_DATE = zone.UPDATE_DATE,
                    UPDATE_USERNB = zone.UPDATE_USERNB,
                    NAME = zone.NAME,
                    ORDER = zone.ORDER,
                    NOTE = zone.NOTE,
                    GOVId = zone.GOVId,

                };
                try
                {
                    db.ZONE.Attach(entity);
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new { Data = new[] { String.Empty }, Total = "0", AggregateResults = "", Errors = new { msg = new { errors = new[] { e.Message } } } });
                }
            }

            return Json(new[] { zone }.ToDataSourceResult(request, ModelState));
        }
        [HttpPost("ZONE_Destroy")]
        //[DisplayActionName(DisplayName = "Delete ZONE")]
        public ActionResult ZONE_Destroy([DataSourceRequest] DataSourceRequest request, [FromBody] ZONE zone)
        {
            if (ModelState.IsValid)
            {
                var entity = new ZONE
                {
                    Id = zone.Id,
                    CREATION_DATE = zone.CREATION_DATE,
                    CREATE_USERNB = zone.CREATE_USERNB,
                    UPDATE_DATE = zone.UPDATE_DATE,
                    UPDATE_USERNB = zone.UPDATE_USERNB,
                    NAME = zone.NAME,
                    ORDER = zone.ORDER,
                    NOTE = zone.NOTE,
                    GOVId = zone.GOVId,

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

            return Json(new[] { zone }.ToDataSourceResult(request, ModelState));
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
