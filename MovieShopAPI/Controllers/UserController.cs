using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("purchase")]
        public async Task<IActionResult> Purchase(PurchaseRequestModel model)
        {
         var purchase = await _userService.PurchaseMovie(model, model.UserId);
       
            if(purchase)
            {
                return Ok(purchase);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        [Route("favorite")]
        public async Task<IActionResult> Favorite(FavoriteRequestModel model)
        {
            await _userService.AddFavorite(model);
            return Ok(model);
        }
            [HttpPost]
            [Route("unfavorite")]
            public async Task<IActionResult> UnFavorite(FavoriteRequestModel model)
            {
                await _userService.RemoveFavorite(model);
                return Ok(model);
            }
            [HttpGet]
            [Route("{id:int}/movie/{movieId:int}/favorite")]
            public async Task<IActionResult> FavoriteExist(int id, int movieId)
            {
                var favoriteMovies = await _userService.FavoriteExists(id, movieId);

                if (favoriteMovies)
                {
                    return Ok(favoriteMovies);
                }
                else
                {
                    return NotFound("Not exits");
                }
            }
            [HttpPost]
            [Route("review")]
            public async Task<IActionResult> Review(ReviewRequestModel model)
            {
                await _userService.AddMovieReview(model);
                return Ok(model);
            }
            [HttpPut]
            [Route("review")]
            public async Task<IActionResult> UpdateReview(ReviewRequestModel model)
            {
                await _userService.UpdateMovieReview(model);
                return Ok(model);
            }
            [HttpDelete]
            [Route("{id:int}/movie/{movieId}")]
            public async Task<IActionResult> DeletePurchase(int id, int movieId)
            {
                await _userService.RemovePurchase(id, movieId);
                return Ok(movieId);
            }
            [HttpGet]
            [Route("{id:int}/purchases")]
            public async Task<IActionResult> GetPurchaseMovies(int id)
            {
                var userPurchases = await _userService.GetAllPurchasesForUser(id);

                return Ok(userPurchases);
            }
            [HttpGet]
            [Route("{id:int}/{movieId:int}/PurchaseDetailByMovieId")]
            public async Task<IActionResult> GetPurchaseDetailByUserIdMovieId(int id, int movieId)
            {
                var purchaseDetail = await _userService.GetPurchaseDetails(id, movieId);
                return Ok(purchaseDetail);
            }
            [HttpGet]
            [Route("{id:int}/favorite")]
            public async Task<IActionResult> GetAllFavorite(int id)
            {
                var favorites = await _userService.GetAllFavoriteForUser(id);
                return Ok(favorites);
            }
            [HttpGet]
            [Route("{id:int}/reviews")]
            public async Task<IActionResult> GetAllReviews(int id)
            {
                var favorite = await _userService.GetAllReviewsByUser(id);
                return Ok(favorite);
            }
            [HttpGet]
            [Route("{id:int}/PurchaseDetailByUserId")]
            public async Task<IActionResult> PurchaseDetailsByUserId(int id)
            {
                var purchases = await _userService.GetAllPurchaseDetailByUserId(id);

                if (!purchases.Any())
                {
                    return NotFound();
                }
                else
                {
                    return Ok(purchases);
                }
            }
        }
    }
