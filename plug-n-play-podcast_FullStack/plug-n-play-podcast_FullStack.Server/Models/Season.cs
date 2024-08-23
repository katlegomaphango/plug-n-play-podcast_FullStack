namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public ICollection<Episode>? Episodes { get; set; }
    }
}
