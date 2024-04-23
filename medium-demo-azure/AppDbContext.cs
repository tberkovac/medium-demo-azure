using Microsoft.EntityFrameworkCore;

namespace medium_demo_azure;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Book> Books => Set<Book>();
}
