namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Preview
    {
        public int Id {  get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Seasons { get; set; }
        public string? Image {  get; set; }
        public ICollection<int>? GenreIds { get; set; }
        public string? Updated {  get; set; }
    }
}
