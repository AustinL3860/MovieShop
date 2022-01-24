using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Services
{
    public interface IMovieService
    {
        // create these service methods absed on your UI/business requirements
        // Controllers will access these methods
        Task<List<MovieCardResponseModel>> GetTop30GrossingMovies();
        Task<MovieDetailsResponseModel> GetMovieDetails(int id);
        Task<List<MovieCardResponseModel>> GetHighestGrossingMovies();
        Task<MovieDetailsResponseModel> GetMovieDetailsById(int id);
        Task<List<MovieCardResponseModel>> GetMoviesByPagination(int pageSize, int page, string title);
        Task<MovieDetailsResponseModel> MoviesSameGenre(int id);

    }
}