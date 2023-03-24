using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DTO.Models;
using DTO.DBServiceRepo;
using DTO.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DTO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public IDBRepo<Movie> MovieRepo { get; }
        public IDBRepo<Actor> ActorRepo { get; }

        public MoviesController(IDBRepo<Movie> MoRepo, IDBRepo<Actor> actorRepo )
        {
            this.MovieRepo = MoRepo;
            ActorRepo = actorRepo;
        }

        [HttpGet("{id:int}", Name = "GetID")]//if we put "/" before id so it consider this url after base url and will not incude api/controller
        //sholud put route to diff. btw all get methods 
        public IActionResult getById(int id)
        {
            var MovieModel = MovieRepo.GetById(id);

            if (MovieModel == null)
            {
                return NotFound();
            }
            MovieWithActors MovieDTO = MapMovieToDTO(MovieModel);

            return Ok(MovieDTO);
        }

        [HttpGet]
        public IActionResult getAll()
        {
            if (MovieRepo.GetAll().Count == 0)
            {
                return NotFound();
            }
            List<MovieWithActors> DTOList = new List<MovieWithActors>();
            foreach(var movie in MovieRepo.GetAll())
            {
                DTOList.Add(MapMovieToDTO(movie));
            }

            return Ok(DTOList);
        }

        [HttpDelete("{id:int}")]
        public IActionResult deleteMovie(int id)
        {
            var Deletedcourse = MovieRepo.GetById(id);

            if (Deletedcourse == null)
            {
                return NotFound();
            }

            try
            {
                MovieRepo.Delete(id);
                List<MovieWithActors> DTOList = new List<MovieWithActors>();
                foreach (var movie in MovieRepo.GetAll())
                {
                    DTOList.Add(MapMovieToDTO(movie));
                }
                return Ok(DTOList);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("{id:int}")]
        public IActionResult put(int id, MovieWithActors MovieDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingMovie = MovieRepo.GetById(id);
                    if (existingMovie == null)
                    {
                        return NotFound();
                    }
                    MapDTOToMovie(existingMovie,MovieDTO);
                    MovieRepo.Update(id, existingMovie);
                    return StatusCode(200, "Data Updated");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult post(MovieWithActors MovieDTO)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Movie nweMovie = MapDTOToMovie(MovieDTO);
                    MovieRepo.Add(nweMovie);
                    //to return created we must send url to the object created and the obj itself
                    //to make a url that detect any domain (after deployment) we use this function
                    string url = Url.Link("GetID", new { id = nweMovie.id });
                    return Created(url, nweMovie);

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }


            return BadRequest(ModelState);
        }

        private MovieWithActors MapMovieToDTO(Movie mov)
        {
            MovieWithActors mapped = new MovieWithActors() { 
                Title = mov.Name,
                Time = mov.Duration,
                MovieType = mov.Type,
                MovieRate = mov.Rate,
                MovieProducer = mov.Producer,
                
            };
            foreach(var actor in mov.Actors)
            {
                mapped.ActorNames.Add(actor.Name);
            }
            return mapped;
        }

        private Movie MapDTOToMovie(MovieWithActors DTO)
        {
            Movie mapped = new Movie()
            {
                Name = DTO.Title,
                Duration = DTO.Time,
                Type = DTO.MovieType,
                Rate = DTO.MovieRate,
                Producer = DTO.MovieProducer,
                Actors = new()

            };
            foreach (var actorName in DTO.ActorNames)
            {
                Actor actor = new Actor()
                {
                    Name = actorName
                };
                //if (actor == null)
                //{
                //    mapped.Actors.Add(new Actor() { Name = actorName});
                //}
                //else
                //{
                    mapped.Actors.Add(actor);
                //}
            }
            return mapped;
        }

        private void MapDTOToMovie(Movie mapped,MovieWithActors DTO)
        {
            mapped.Name = DTO.Title;
            mapped.Duration = DTO.Time;
            mapped.Type = DTO.MovieType;
            mapped.Rate = DTO.MovieRate;
            mapped.Producer = DTO.MovieProducer;

            mapped.Actors = new();
            foreach (var actorName in DTO.ActorNames)
            {
                //Actor actor = ActorRepo.GetByName(actorName);
                //if (actor == null)
                //{
                //    mapped.Actors.Add(new Actor() { Name = actorName });
                //}
                //else
                //{
                    mapped.Actors.Add(new Actor() { Name = actorName , Movie=MovieRepo.GetById(mapped.id)});
                //}
            }
            
        }
    }
}
