using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data; //to call in  different file

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }
}
