using System.Text.Json.Serialization;

namespace BackEnd_WebAPI.Models
{
    public class Genre
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("shows")]
        public string[] ShowIds { get; set; } = [];
    }
}
