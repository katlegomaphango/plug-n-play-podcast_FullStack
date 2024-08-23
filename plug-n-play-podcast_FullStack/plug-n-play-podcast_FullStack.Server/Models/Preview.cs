namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Preview
    {
        public int Id {  get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Seasons { get; set; } = 0;
        public string Image {  get; set; } = string.Empty;
        public string Updated {  get; set; } = string.Empty;

        // Relationships
        public virtual Show Show { get; set; } = new Show();
        public virtual ICollection<Genre> Genres { get; set; } = [];
    }
}
