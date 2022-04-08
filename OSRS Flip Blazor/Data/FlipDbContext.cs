using Microsoft.EntityFrameworkCore;
using OSRS_Flip_Blazor.Models;

namespace OSRS_Flip_Blazor.Data
{
    public class FlipDbContext : DbContext
    {
        public FlipDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Flip> Flips { get; set; }
    }
}
