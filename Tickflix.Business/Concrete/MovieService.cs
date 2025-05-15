using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IRepository<Actor> _actorRepository;

        public MovieService(IRepository<Movie> movieRepository, IRepository<Actor> actorRepository)
        {
            _movieRepository = movieRepository;
            _actorRepository = actorRepository;
        }


        public Movie Add(Movie movie, List<int> Actors)
        {
            var actorEntities = _actorRepository.GetAll()
                .Where(a => Actors.Contains(a.Id)).ToList();
            movie.Actors = actorEntities;
            _movieRepository.Save();
            return _movieRepository.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.Delete(movie);
        }

        public IQueryable<Movie> GetAll()
        {
            return _movieRepository.GetAll().Include(m => m.Cinema).Include(m => m.Producer).Include(m => m.Actors);
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public Movie Update(Movie movie)
        {
            return _movieRepository.Update(movie);
        }


        public List<Movie> GetFilteredMovies(string searchString)
        {
            var moviesQuery = _movieRepository.GetAll()
                .Include(m => m.Cinema)
                .Include(m => m.Producer)
                .Include(m => m.Actors)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(searchString));
            }

            return moviesQuery.ToList();
        }
    }
}
