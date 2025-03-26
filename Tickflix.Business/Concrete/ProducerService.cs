
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Microsoft.EntityFrameworkCore;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class ProducerService : IProducerService
    {
        private readonly IRepository<Producer> _producerRepository;

        public ProducerService(IRepository<Producer> producerRepository)
        {
            _producerRepository = producerRepository;
        }
        public Producer Add(Producer producer)
        {
            return _producerRepository.Add(producer);
        }

        public void Delete(Producer producer)
        {
            _producerRepository.Delete(producer);
        }

        public IQueryable<Producer> GetAll()
        {
            return _producerRepository.GetAll();
        }

        public Producer GetById(int id)
        {
            return _producerRepository.GetById(id);
        }

        public Producer Update(Producer producer)
        {
             return (_producerRepository.Update(producer));
        }
    }
}
