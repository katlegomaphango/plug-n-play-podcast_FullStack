﻿namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string File { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
