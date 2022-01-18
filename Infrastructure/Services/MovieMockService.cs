using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieMockService : IMovieService
    {
        public Task<MovieDetailsResponseModel> GetMovieDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<MovieCardResponseModel> GetTop30GrossingMovies()
        {
            var movies = new List<MovieCardResponseModel>()
            {
                new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="" },
               new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="" },
               new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="" }
               };
            return movies;
        }

        Task<List<MovieCardResponseModel>> IMovieService.GetTop30GrossingMovies()
        {
            throw new NotImplementedException();
        }
    }
}
