using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class CinemaService : ICinemaService
    {
        private readonly IRepository<Cinema> _cinemaRepository;

        public CinemaService(IRepository<Cinema> cinemaRepository)
        {
            _cinemaRepository = cinemaRepository;
        }
        public Cinema Add(Cinema cinema)
        {
            return _cinemaRepository.Add(cinema);
        }

        public void Delete(Cinema cinema)
        {
            _cinemaRepository.Delete(cinema);
        }

        public IQueryable<Cinema> GetAll()
        {
            return _cinemaRepository.GetAll();
        }

        public Cinema GetById(int id)
        {
            return _cinemaRepository.GetById(id);
        }

        public Cinema Update(Cinema cinema)
        {
            return (_cinemaRepository.Update(cinema));
        }
    }
}
