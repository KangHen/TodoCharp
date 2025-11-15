using Microsoft.EntityFrameworkCore;
using Todo.App.Models;

namespace Todo.App.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<Activity> Activities { get; set; }
}
