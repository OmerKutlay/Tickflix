using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public Movie Add(Movie movie)
        {
            return _movieRepository.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.Delete(movie);
        }

        public IQueryable<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public Movie Update(Movie movie)
        {
            return _movieRepository.Update(movie);
        }
    }
}
