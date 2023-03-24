using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DTO.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int? Duration { get; set; }
        public string? Type { get; set; }
        public float? Rate { get; set; }
        public string? Producer { get; set; }
        public virtual List<Actor> Actors { get; set; }

    }
}
