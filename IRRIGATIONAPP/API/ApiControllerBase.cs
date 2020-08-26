using IRRIGATIONDLL.Models;
using Microsoft.AspNetCore.Mvc;
namespace IRRIGATIONAPP.API
{

    //[Authorize(Policy = "ApiUser")]
    //[ApiController]
    //[Route("api/[controller]/[action]")]
    //[ApiUserDBToken]
    //[Authorize(Policy = "ApiUserDBToken", Roles = "admin")]

    //[Authorize]
    public class ApiControllerBase : Controller
    {

        protected readonly AppDBContext db;
        public ApiControllerBase(AppDBContext _db)
        {
            db = _db;
        }
    }
    public class results
    {
        public bool status;
        public object content;
        public string error_des;
        public int error_code;
        public results(bool status, object content, string error_des = "", int error_code = 0)
        {
            this.status = status;
            this.content = content;
            this.error_des = error_des;
            this.error_code = error_code;
        }
    }
}