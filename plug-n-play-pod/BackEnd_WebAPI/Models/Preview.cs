using System.Text.Json.Serialization;

namespace BackEnd_WebAPI.Models
{
    public class Preview
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
        [JsonPropertyName("seasons")]
        public int Seasons { get; set; } = 0;
        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;
        [JsonPropertyName("genres")]
        public int[] GenreIds { get; set; } = Array.Empty<int>();
        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        // Relationships
        //public virtual Show Show { get; set; } = new Show();
        //public virtual ICollection<Genre> Genres { get; set; } = [];
    }
}
