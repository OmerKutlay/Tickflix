using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface IMovieService
    {
        Movie Add(Movie movie);
        Movie Update(Movie movie);
        Movie GetById(int id);
        void Delete(Movie movie);
        IQueryable<Movie> GetAll();
    }
}
