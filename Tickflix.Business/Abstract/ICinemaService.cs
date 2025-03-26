using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface ICinemaService
    {
        Cinema Add(Cinema cinema);
        Cinema Update(Cinema cinema);
        Cinema GetById(int id);
        void Delete(Cinema cinema);
        IQueryable<Cinema> GetAll();
    }
}
