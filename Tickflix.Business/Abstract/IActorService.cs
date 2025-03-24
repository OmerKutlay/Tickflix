using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface IActorService
    {
        Actor Add(Actor actor);
        Actor Update(Actor actor);
        Actor GetById(int id);
        void Delete(int id);
        IQueryable<Actor> GetAll();
    }
}
