namespace DTO.DTO
{
    public class MovieWithActors
    {
        public string Title { get; set; }
        public int? Time { get; set; }
        public string? MovieType { get; set; }
        public float? MovieRate { get; set; }
        public string? MovieProducer { get; set; }
        public List<string> ActorNames { get; set; } = new List<string>();
    }
}
