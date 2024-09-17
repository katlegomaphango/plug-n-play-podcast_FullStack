using System.Text.Json.Serialization;

namespace BackEnd_WebAPI.Models
{
    public class Show
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty ;

        [JsonPropertyName("seasons")]
        public Season[] Seasons { get; set; } = [];

        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }
    }
}
