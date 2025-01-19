using Microsoft.EntityFrameworkCore;
using textT.Models;

namespace textT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Paste> Pastes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
    }
}
