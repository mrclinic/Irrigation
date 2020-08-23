using System;
using System.Collections.Generic;
using System.Linq;
using IRRIGATION.API;
using IRRIGATION.Models;
using IRRIGATIONDLL.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace IRRIGATIONAPP.Qualify.Controllers
{
    [Area("IRRIGATION")]
    //[Authorize(Policy = "ActionPermission")]
    [Route("[area]/[controller]")]
    public class SETTINGController :
        ApiControllerBase
    {
        public SETTINGController(AppDBContext _db) : base(_db){}


        [HttpGet("IRRIGATION/SETTING/index")]
        public ActionResult Index()
        {
            return View();
        }
        // [DisplayActionName(DisplayName = "Read All Account Types")]
        [HttpGet("SETTING_Read")]
        public ActionResult SETTING_Read([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                IQueryable<SETTING> _SETTING = db.SETTING.AsQueryable();
                //IEnumerable<SETTING> _SETTING = query.ToList().Skip(request.Page * request.PageSize).Take(request.PageSize).ToList();// query.ToList().Skip((request.Page-1) * request.PageSize).Take(request.PageSize).ToList();//db.SETTING.ToList();//.Skip(request.Page).Take(request.PageSize).ToList();
                DataSourceResult result = _SETTING.ToDataSourceResult(request, SETTING => new
                {
                    Id = SETTING.Id,                    
                    NAME = SETTING.NAME,
                    TITLE = SETTING.TITLE,
                    VALUE = SETTING.VALUE,
                    NOTE = SETTING.NOTE,
                    CREATION_DATE = SETTING.CREATION_DATE,
                    USERNB = SETTING.USERNB
                });
               //result.Total = query.Count();
                return Json(result);
            }
            catch (Exception e)
            {
                return Json(new
                {
                    Data = new[] { String.Empty },
                    Total = "0",
                    AggregateResults = "",
                    Errors = new { msg = new { errors = new[] { e.Message } } }
                });
            }
        }
        
        [HttpPost("SETTING_Create")]
        //[DisplayActionName(DisplayName = "Add New Account Type")]
        public ActionResult SETTING_Create([DataSourceRequest]DataSourceRequest request, [FromBody] SETTING SETTING)
        {
            if (ModelState.IsValid)
            {
                var entity = new SETTING
                {
                    NAME = SETTING.NAME,
                    TITLE = SETTING.TITLE,
                    VALUE = SETTING.VALUE,
                    NOTE = SETTING.NOTE,
                    CREATION_DATE = SETTING.CREATION_DATE,
                    USERNB = SETTING.USERNB
                };
                try
                {
                    db.SETTING.Add(entity);
                    db.SaveChanges();
                    SETTING.Id = entity.Id;
                }
                catch (Exception e)
                {
                    return Json(new
                    {
                        Data = new[] { String.Empty },
                        Total = "0",
                        AggregateResults = "",
                        Errors = new { msg = new { errors = new[] { e.Message } } }
                    });
                }
            }

            return Json(new[] { SETTING }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost("SETTING_Update")]
        //[DisplayActionName(DisplayName = "Edit Account Type")]
        public ActionResult SETTING_Update([DataSourceRequest]DataSourceRequest request, [FromBody] SETTING SETTING)
        {
            if (ModelState.IsValid)
            {
                var entity = new SETTING
                {
                    Id = SETTING.Id,
                    NAME = SETTING.NAME,
                    TITLE = SETTING.TITLE,
                    VALUE = SETTING.VALUE,
                    NOTE = SETTING.NOTE,
                    CREATION_DATE = SETTING.CREATION_DATE,
                    USERNB = SETTING.USERNB
                };
                try
                {
                    db.SETTING.Attach(entity);
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new
                    {
                        Data = new[] { String.Empty },
                        Total = "0",
                        AggregateResults = "",
                        Errors = new { msg = new { errors = new[] { e.Message } } }
                    });
                }
            }

            return Json(new[] { SETTING }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost("SETTING_Destroy")]
        public ActionResult SETTING_Destroy([DataSourceRequest]DataSourceRequest request, [FromBody] SETTING SETTING)
        {
            if (ModelState.IsValid)
            {
                var entity = new SETTING
                {
                    Id = SETTING.Id,
                    NAME = SETTING.NAME,
                    TITLE = SETTING.TITLE,
                    VALUE = SETTING.VALUE,
                    NOTE = SETTING.NOTE,
                    CREATION_DATE = SETTING.CREATION_DATE,
                    USERNB = SETTING.USERNB
                };

                //long ss = db.Database.ExecuteSqlCommand(" delete from dbo.SETTING  where NB = " + SETTING.NB);
                try
                {
                    db.Remove(entity);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return Json(new
                    {
                        Data = new[] { String.Empty },
                        Total = "0",
                        AggregateResults = "",
                        Errors = new { msg = new { errors = new[] { e.Message } } }
                    });
                }

                db.SaveChanges();
            }

            return Json(new[] { SETTING }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }

}
