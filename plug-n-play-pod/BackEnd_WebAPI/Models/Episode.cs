using System.Text.Json.Serialization;

namespace BackEnd_WebAPI.Models
{
    public class Episode
    {
        [JsonPropertyName("episode")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("file")]
        public string File { get; set; } = string.Empty ;
    }
}
