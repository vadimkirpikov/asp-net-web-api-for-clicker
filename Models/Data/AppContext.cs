using Microsoft.EntityFrameworkCore;
namespace Rest.Models.Data;

public class ApplicationContext: DbContext
{
    public DbSet<User>? Users { get; set; }
    public ApplicationContext(DbContextOptions options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    // private void CreateDb()
    // {
    //     // Database.EnsureDeleted();
    //     
    // }
}