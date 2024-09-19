using System.Text.Json.Serialization;

namespace BackEnd_WebAPI.Models
{
    public class Season
    {
        [JsonPropertyName("season")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty ;

        [JsonPropertyName("episodes")]
        public Episode[] Episodes { get; set; } = [];
    }
}
