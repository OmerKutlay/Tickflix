using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class ActorService : IActorService
    {
        private readonly IRepository<Actor> _actorService;
        public ActorService(IRepository<Actor> actorRepository)
        {
            _actorService = actorRepository;
        }

        public Actor Add(Actor actor)
        {
            return _actorService.Add(actor);
        }

        public void Delete(Actor actor)
        {
            _actorService.Delete(actor);
        }

        public IQueryable<Actor> GetAll()
        {
            return _actorService.GetAll();
        }

        public Actor GetById(int id)
        {
            return _actorService.GetById(id);
        }

        public Actor Update(Actor actor)
        {
            return _actorService.Update(actor);
        }
    }
}
