using Microsoft.EntityFrameworkCore;
using mosh.Models;

namespace mosh.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MovieModel> Movies { get; set; }
    }
}
