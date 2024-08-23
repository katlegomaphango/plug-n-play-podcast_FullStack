namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public ICollection<Episode> Episodes { get; set; } = [];
    }
}
