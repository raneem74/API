using DTO.Models;
using Microsoft.EntityFrameworkCore;

namespace DTO.DBServiceRepo
{
    public class MovieRepo : IDBRepo<Movie>
    {
        public MovieContext Context { get; }

        //request service of type mainDbContext to be injected in Ctor
        public MovieRepo(MovieContext context)
        {
            Context = context;
        }

        public Movie GetById(int id)
        {
            return Context.Movies.Include(m => m.Actors).FirstOrDefault(i => i.id == id);
        }

        public List<Movie> GetAll()
        {
            return Context.Movies.Include(m => m.Actors).ToList();
        }

        public void Add(Movie entity)
        {
            Context.Movies.Add(entity);
            Context.SaveChanges();
        }

        public void Update(int id, Movie entity)
        {
            //var existingMovie = Context.Movies.Find(id);

            //if (existingMovie != null)
            //{
            //    existingMovie.Producer = entity.Producer;
            //    existingMovie.Rate = entity.Rate;
            //    existingMovie.Duration = entity.Duration;
            //    existingMovie.Type = entity.Type;
            //    existingMovie.Name = entity.Name;
            //    existingMovie.Actors = new();
            //    foreach (Actor actor in entity.Actors)
            //    {
            //        existingMovie.Actors.Add(actor);
            //    }

            //}
                Context.SaveChanges();
        }

        public void Delete(int id)
        {
            Context.Remove(Context.Movies.Include(m => m.Actors).FirstOrDefault(m => m.id == id));
            Context.SaveChanges();
        }

        public Movie GetByName(string id)
        {
            throw new NotImplementedException();
        }
    }
}
