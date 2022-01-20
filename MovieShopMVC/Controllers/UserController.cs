using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MovieShopMVC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // Show Movies User Purchased
        // Show Movies User Favorited
        // Purchase/Buy a Movie
        // Favorite a Movie
        // UnFavorite a Movie
        // Add Movie Review
        // Edit Movie Review

        //ASP.NET has Filters Authorization
        private readonly IUserService _userService;

        public UserController(IUserService _userService)
        {
            _userService = _userService;
        }

        [HttpGet]
      public async Task<IActionResult> Purchases()
        {
            // HttpContext => Encapsulates all the Http Request Information
            //var isLogicId = HttpContext.User.Identity.IsAuthenticated;
            var userID = Convert.ToUInt32(HttpContext?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
                // call user service with legend in user id and get the movies user purchased from the Purchase table
            
          
           
            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Favorites()
        {
            var userId = Convert.ToInt32(HttpContext?.User?.Claims?.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Review()
        {
            // HttpContext => Encapsulates all the Http Request Information
            //var isLogicId = HttpContext.User.Identity.IsAuthenticated;
            var userID = Convert.ToUInt32(HttpContext?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            // call user service with legend in user id and get the movies user purchased from the Purchase table



            return View();
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Buy()
        {
            // HttpContext => Encapsulates all the Http Request Information
            //var isLogicId = HttpContext.User.Identity.IsAuthenticated;
            var userID = Convert.ToUInt32(HttpContext?.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            // call user service with legend in user id and get the movies user purchased from the Purchase table



            return View();
        }
    }

}
