using Microsoft.AspNetCore.Identity;

namespace plug_n_play_podcast_FullStack.Server.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
