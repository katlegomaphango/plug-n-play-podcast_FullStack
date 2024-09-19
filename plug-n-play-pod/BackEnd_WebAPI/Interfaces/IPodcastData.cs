using BackEnd_WebAPI.Models;

namespace BackEnd_WebAPI.Interfaces
{
    public interface IPodcastData
    {
        Task<List<Preview>> GetPreviewsAsync();

        Task<Genre> GetGenreAsync(int id);

        Task<Show> GetShowAsync(string id);
    }
}
