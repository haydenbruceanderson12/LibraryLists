using LibraryLists.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryLists.Data
{  
    public class AppDbContext : DbContext
    {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<LibraryFullList> Library { get; set; }
    }
}
