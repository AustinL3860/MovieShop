using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Task<List<MovieCardResponseModel>> GetHighestGrossingMovies()
        {
            throw new NotImplementedException();
        }

        public async Task<MovieDetailsResponseModel> GetMovieDetails(int id)
        {
            var movieDetails = await _movieRepository.GetById(id);
            var rating = await _movieRepository.GetMovieRating(id);
            var movieModel = new MovieDetailsResponseModel
            {
                Id = movieDetails.Id,
                Title = movieDetails.Title,
                PosterUrl = movieDetails.PosterUrl,
                BackdropUrl = movieDetails.BackdropUrl,
                ImdbUrl = movieDetails.ImdbUrl,
                Rating = rating,
            };

            foreach (var genre in movieDetails.MovieGenres)
            {
                movieModel.Genres.Add(new GenreModel { Id = genre.GenreId, Name = genre.Genre.Name });
            }

            foreach (var trailer in movieDetails.Trailers)
            {
                movieModel.Trailers.Add(new TrailerModel { Id = trailer.Id, Name = trailer.Name, TrailerUrl = trailer.TrailerUrl });
            }

            return movieModel;
        }

        public Task<MovieDetailsResponseModel> GetMovieDetailsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<MovieCardResponseModel>> GetMoviesByPagination(int pageSize, int page, string title)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieCardResponseModel>> GetTop30GrossingMovies()
        {
            var movies = await _movieRepository.Get30HighestGrossingMovies();
            // map the data from movies (List<Movie>) to movieCards (List<MovieCardResponseModel>)

            var movieCards = new List<MovieCardResponseModel>();

            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel { Id = movie.Id, Title = movie.Title, PosterUrl = movie.PosterUrl });
            }

            return movieCards;
        }

        public Task<MovieDetailsResponseModel> MoviesSameGenre(int id)
        {
            throw new NotImplementedException();
        }
    }
}