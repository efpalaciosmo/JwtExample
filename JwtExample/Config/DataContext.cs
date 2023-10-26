using JwtExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace JwtExample.Config;

public class DataContext: DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users => Set<User>();
}