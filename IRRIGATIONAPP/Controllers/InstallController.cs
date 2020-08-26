using System;
using System.Collections.Generic;
using System.Linq;
using IRRIGATIONDLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;


namespace IRRIGATIONAPP.Controllers
{
    public class InstallController : Controller
    {
        private readonly IActionDescriptorCollectionProvider _provider;
        private readonly AppDBContext _db;

        public InstallController(IActionDescriptorCollectionProvider provider, AppDBContext db)
        {
            _provider = provider;
            _db = db;
        }

        public IActionResult ReadRoutes()
        {

            var routes = _provider.ActionDescriptors.Items.Select(x => new
            {
                Action = x.RouteValues["Action"],
                Controller = x.RouteValues["Controller"],
                Area = x.RouteValues["Area"],
                //Url = x.RouteValues["URL"],
                //Name = x.AttributeRouteInfo.Name,
                //Template = x.AttributeRouteInfo.Template
            }).ToList();

            return Ok(routes);
        }

        public IActionResult InitialConstanIndex()
        {

            //2.	صفة الشركة (شركة، ورشة).
            List<CONSTANT> comapnyAdiectives = new List<CONSTANT>() {
            new CONSTANT() {
                NAME = "شركة",
                TYPE ="COMPANY_ADJECTIVE",
                ORDER = "1"
            },
            new CONSTANT() {
                NAME = "ورشة",
                TYPE ="COMPANY_ADJECTIVE",
                ORDER = "2"
            }
            };
            //3.	نوع السجل (تجاري، صناعي، نقابة حرفيين).
            List<CONSTANT> recordTypes = new List<CONSTANT>() {
            new CONSTANT() {
                NAME = "تجاري",
                TYPE ="RECORD_TYPE",
                ORDER = "1"
            },
            new CONSTANT() {
                NAME = "صناعي",
                TYPE ="RECORD_TYPE",
                ORDER = "2"
            },
            new CONSTANT() {
                NAME = "نقابة حرفيين",
                TYPE ="RECORD_TYPE",
                ORDER = "3"
            }
            };
            //7.	المنتجات بأنواعها (pe, pvc, metal).
            List<CONSTANT> productTypes = new List<CONSTANT>() {
            new CONSTANT() {
                NAME = "pe",
                TYPE ="PROJECT_TYPE",
                ORDER = "1"
            },
            new CONSTANT() {
                NAME = "pvc",
                TYPE ="PROJECT_TYPE",
                ORDER = "2"
            },
            new CONSTANT() {
                NAME = "metal",
                TYPE ="PROJECT_TYPE",
                ORDER = "3"
            }
            };
            //8.	حالة الشركة: محرومة أم لا.
            List<CONSTANT> comapnyStatus = new List<CONSTANT>() {
            new CONSTANT() {
                NAME = "نعم",
                TYPE ="COMPANY_STATUS",
                ORDER = "1"
            },
            new CONSTANT() {
                NAME = "لا",
                TYPE ="COMPANY_STATUS",
                ORDER = "2"
            }
            };
            try
            {
                _db.CONSTANT.AddRange(comapnyAdiectives);
                _db.CONSTANT.AddRange(recordTypes);
                _db.CONSTANT.AddRange(productTypes);
                _db.CONSTANT.AddRange(comapnyStatus);
                _db.SaveChanges();
                return Json(new
                {
                    Data = new { msg = "SUCCESS" },
                    Total = "0",
                    AggregateResults = "",
                    Errors = new { String.Empty }
                });
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
    }
}
