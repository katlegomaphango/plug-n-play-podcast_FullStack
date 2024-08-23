namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Relationships
        public virtual ICollection<Preview> Previews { get; set; } = [];
        public virtual ICollection<Show> Shows { get; set; } = [];
    }
}
