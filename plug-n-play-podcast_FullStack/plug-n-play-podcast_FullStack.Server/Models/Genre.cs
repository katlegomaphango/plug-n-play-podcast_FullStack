namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ICollection<int>? ShowIds { get; set; }
    }
}
