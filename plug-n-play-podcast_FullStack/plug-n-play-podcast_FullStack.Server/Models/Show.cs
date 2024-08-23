namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Show
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Relationships
        public virtual ICollection<Genre> Genres { get; set; } = [];
        public virtual ICollection<Season> Seasons { get; set; } = [];
    }
}
