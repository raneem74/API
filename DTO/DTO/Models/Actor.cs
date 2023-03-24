namespace DTO.Models
{   public enum Gender { Male , Female }
    public class Actor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Gender? Gender { get; set; }
        public int? Age { get; set; }
        public string? Address { get; set; }
        public int? Salary { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
