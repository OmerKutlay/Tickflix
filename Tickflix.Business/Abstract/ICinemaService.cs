using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface ICinemaService
    {
        Cinema Add(Cinema cinema);
        Cinema Update(Cinema cinema);
        Cinema GetById(int id);
        void Delete(int id);
        IQueryable<Cinema> GetAll();
    }
}
