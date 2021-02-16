using Microsoft.EntityFrameworkCore;
using TrackListAPI.Models;

namespace TrackListAPI.Data
{
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options) {}

        public DbSet<Track> Tracks { get; set; }
    }
}