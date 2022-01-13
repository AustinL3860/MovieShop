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
    }
}
