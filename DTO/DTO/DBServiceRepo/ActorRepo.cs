using DTO.Models;

namespace DTO.DBServiceRepo
{
    public class ActorRepo : IDBRepo<Actor>
    {

        public MovieContext Context { get; }

        //request service of type mainDbContext to be injected in Ctor
        public ActorRepo(MovieContext context)
        {
            Context = context;
        }

        public void Add(Actor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetByName(string name)
        {
            return Context.Actors.FirstOrDefault(a => a.Name == name);
        }

        public void Update(int id, Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}
