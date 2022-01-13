using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService
    {
        public List<MovieCardResponseModel> GetTop30GrossingMovies()

        {
            var movies = new List<MovieCardResponseModel>()
            {
                new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="https://flxt.tmsimg.com/assets/p7825626_p_v10_af.jpg" },
               new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="https://flxt.tmsimg.com/assets/p7825626_p_v10_af.jpg" },
               new MovieCardResponseModel() {Id =1, Title="Inception", PosterUrl="https://flxt.tmsimg.com/assets/p7825626_p_v10_af.jpg" }
               };
            return movies;
            
        }
    }
}
