﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace DTO.Models
{
    public class MovieContext : DbContext 
    {
        public MovieContext(DbContextOptions<MovieContext> options)
       : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

    }
}
