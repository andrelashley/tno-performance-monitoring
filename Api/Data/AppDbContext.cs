using Api.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Snippet> Snippets => Set<Snippet>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        optionsBuilder
            .UseSqlite($"Data Source={Path.Join(path, "tno.db")}");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        SeedData.Seed(builder);
    }
}