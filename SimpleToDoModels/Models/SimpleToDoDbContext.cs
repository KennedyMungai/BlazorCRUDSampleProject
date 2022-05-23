using Microsoft.EntityFrameworkCore;

namespace SimpleToDoModels.Models;

public class SimpleToDoDbContext : DbContext
{
    public DbSet<SimpleToDoModels>? SimpleToDoModel { get; set; }
    
    public SimpleToDoDbContext(DbContextOptions<SimpleToDoDbContext> options) : base(options)
    {
        
    }
}