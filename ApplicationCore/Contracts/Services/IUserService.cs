using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        Task<bool> PurchaseMovie(PurchaseRequestModel purchaseRequest, int userId);
        Task<bool> IsMoviePurchased(PurchaseRequestModel purchaseRequest, int userId);
        Task RemoveFavorite(FavoriteRequestModel favoriteRequest);
        Task<PurchaseResponseModel> GetAllPurchasesForUser(int id);
        Task<PurchaseDetailsResponseModel> GetPurchaseDetails(int userId, int movieId);
        Task AddFavorite(FavoriteRequestModel favoriteRequest);
        Task <PurchaseRequestModel>RemovePurchase(int id, int movieId);
        
        Task<bool> FavoriteExists(int id, int movieId);
        Task<FavoriteResponseModel> GetAllFavoriteForUser(int id);
        Task AddMovieReview(ReviewRequestModel reviewRequest);
        Task UpdateMovieReview(ReviewRequestModel reviewRequest);
        Task DeleteMovieReview(int userId, int movieId);
        Task<UserReviewResponseModel> GetAllReviewsByUser(int id);
        Task<UserReviewResponseModel> GetAllPurchaseDetailByUserId(int id); 
    }
}