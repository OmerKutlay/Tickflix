using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface IProducerService
    {
        Producer Add(Producer producer);
        Producer Update(Producer producer);
        Producer GetById(int id);
        void Delete(Producer producer);
        IQueryable<Producer> GetAll();
    }
}
