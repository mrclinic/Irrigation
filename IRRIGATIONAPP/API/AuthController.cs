//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using QUALIFYAPP.ViewModels;
//using QUALIFYDLL.Models;

//namespace QUALIFYAPP.API
//{
//    //[Route("api/[controller]")]
//    //[ApiController]
//    [AllowAnonymous]
//    [Route("api/[controller]")]

//    public class AuthController : ApiControllerBase
//    {
//        private readonly UserManager<AppUser> _userManager;
//        public AuthController(AppDBContext _db, UserManager<AppUser> userManager/*, IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions*/) : base(_db)
//        {
//            _userManager = userManager;
//        }
//        // POST api/auth/login
//        [HttpPost("login")]
//        public async Task<results> login([FromBody] CredentialsViewModel credentials)
//        {
//            string Email = credentials.UserName;
//            string Password = credentials.Password;
//            var users = db.USER;
//            var userToVerify = db.USER.Where(p => p.EMAIL.Equals(Email)).ToList();
//            //db.USER
//            // get the user to verifty
//            //var userToVerify = await _userManager.FindByNameAsync(Email);

//            if (userToVerify == null)
//            {
//                return new results(true, null, "Email or password is wrong");
//            }
//            // check the credentials
//            //if (await _userManager.CheckPasswordAsync(userToVerify, Password))
//            var tempUser = userToVerify.FirstOrDefault();
//            if (tempUser.PASSWORD.Equals(Password))
//            {
//                //check if dublicated token token
//                var dublicated_token1 = tempUser.UserApiTokens.ToList();
//                var dublicated_token = dublicated_token1.Where(x => /*x.DeviceToken == FCM_Token ||*/ x.DeviceToken == "" || x.DeviceToken == null).ToList();
//                if (dublicated_token.Count > 0)
//                {
//                    db.UserApiTokens.RemoveRange(dublicated_token);
//                    db.SaveChanges();
//                }

//                if (tempUser.UserApiTokens.Count >= 3)
//                {
//                    // remove old token
//                    db.UserApiTokens.RemoveRange(tempUser.UserApiTokens.OrderByDescending(x => x.LoginDate).Skip(2).ToList());
//                }

//                // create new logion
//                UserApiToken userApiToken = new UserApiToken() { UserId = tempUser.Id, /*DeviceToken = FCM_Token, Platform = Platform, Lang = lang*/ };
//                db.UserApiTokens.Add(userApiToken);

//                db.SaveChanges();

//                return new results(true, new UserApiViewModel(tempUser, userApiToken.Id));
//            }
//            else
//            {
//                return new results(false, null, "Email or password is wrong");
//            }
//        }
//    }
//}