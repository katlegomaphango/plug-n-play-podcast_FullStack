using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using plug_n_play_podcast_FullStack.Server.Models;

namespace plug_n_play_podcast_FullStack.Server.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Preview> Previews { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Show> Shows { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configuring entities' relationships and properties here

            // Preview-Show Relationship
            builder.Entity<Preview>().HasOne(p => p.Show).WithOne().HasForeignKey<Preview>(p => p.Id);

            // Preview-Genre Many-to-Many Relationship
            builder.Entity<Preview>().HasMany(p => p.Genres).WithMany(g => g.Previews);

            // Show-Genre Many-to-Many Relationship
            builder.Entity<Show>().HasMany(s => s.Genres).WithMany(g => g.Shows);

            // Show-Season One-to-Many Relationship
            builder.Entity<Show>().HasMany(s => s.Seasons).WithOne();

            // Season-Episode One-to-Many Relationship
            builder.Entity<Season>().HasMany(s => s.Episodes).WithOne();
        }
    }
}
