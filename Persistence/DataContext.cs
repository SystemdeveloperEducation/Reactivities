using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
/// <summary>
/// The DataContext class is the bridge between the application and the database.
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Activity> Activities { get; set; }
}
