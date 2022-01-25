using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        /*
         [HttpGet]
        [Route("toppurchasedmovies")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _adminService.GetHighestGrossingMovies();
            if (!movies.Any())
            {
                return NotFound();
            }
          
        return Ok(movies);
        */
        }
    }

