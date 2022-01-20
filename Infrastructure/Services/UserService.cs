using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddFavorite(FavoriteRequestModel favoriteRequest)
        {
            int userId = favoriteRequest.UserId;
            int movieId = favoriteRequest.MovieId;
            var addFavorite = await _userRepository.AddFavorite(userId, movieId);
        }

        public async Task AddMovieReview(ReviewRequestModel reviewRequest)
        {
            int movieId = reviewRequest.MovieId;
            int userId = reviewRequest.UserId;
            decimal rating = reviewRequest.Rating;
            string reviewText = reviewRequest?.ReviewText;
            var addMovieReview = await _userRepository.AddMovieReview(userId, movieId, rating, reviewText);
        }

        public async Task DeleteMovieReview(int userId, int movieId)
        {
            await _userRepository.DeleteMovieReview(userId, movieId);
        }

        public async Task<bool> FavoriteExists(int id, int movieId)
        {

            Favorite favorite = await _userRepository.GetFavorite(id, movieId);

            return favorite != null;
        }

        public Task<FavoriteResponseModel> GetAllFavoriteForUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PurchaseResponseModel> GetAllPurchasesForUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserReviewResponseModel> GetAllReviewsByUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PurchaseDetailsResponseModel> GetPurchaseDetails(int userId, int movieId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsMoviePurchased(PurchaseRequestModel purchaseReques, int userId)
        {
            var isPurchased = await _userRepository.GetPurchasesDetails(userId, purchaseReques.MovieId);

            return isPurchased != null;
        }

        public async Task<bool> PurchaseMovie(PurchaseRequestModel purchaseRequest, int userId)
        {

            var purchase = await _userRepository.AddNewPurchase(userId, purchaseRequest.MovieId, purchaseRequest.TotalPrice);

            return purchase != null;
        }

        public async Task RemoveFavorite(FavoriteRequestModel favoriteRequest)
        {
            var remove = await _userRepository.RemoveFavorite(favoriteRequest.UserId, favoriteRequest.MovieId);
        }

        public async Task UpdateMovieReview(ReviewRequestModel reviewRequest)
        {
            var updateReview = await _userRepository.UpdateMovieReview
               (
                   reviewRequest.MovieId,
                   reviewRequest.UserId,
                   reviewRequest.Rating,
                   reviewRequest.ReviewText
               );
        }
    }
}