//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Project2.DAL.Interfaces;

//namespace WEBAPI__PR2.Controllers
//{
//    public class UserProfileController : Controller
//    {
//        private IUnitOfWork uow;

//        public UserProfileController(IUnitOfWork uow)
//        {
//            this.uow = uow;
//        }

//        [Authorize]
//        [HttpGet("GetAuthorize")]
//        //GET: /api/UserProfile
//        public async Task<ActionResult<Object>> GetUserProfile()
//        {
//            string userId = User.Claims.First(c => c.Type == "UserID").Value;
//            var user = await uow.UserManager.FindByIdAsync(userId);

//            return new
//            {
//                user.UserName,
//                user.FirstName,
//                user.Email 
//            };
//        }
//    }
//}
