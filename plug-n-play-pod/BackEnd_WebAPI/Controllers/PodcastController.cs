using BackEnd_WebAPI.Interfaces;
using BackEnd_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {
        private readonly IPodcastData _previews;

        public PodcastController(IPodcastData previews)
        {
            _previews = previews;
        }

        [HttpGet]
        public async Task<IEnumerable<Preview>> GetPreviews()
        {
            return await _previews.GetPreviewsAsync();
        }

        [HttpGet("{id}")]
        public async Task<Genre> GetGenre(int id)
        {
            return await _previews.GetGenreAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<Show> GetShow(string id)
        {
            return await _previews.GetShowAsync(id);
        }
    }
}
