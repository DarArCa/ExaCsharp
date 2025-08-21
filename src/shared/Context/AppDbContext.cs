
using Microsoft.EntityFrameworkCore;

namespace CoffeProject.shared.Context
{
    public class AppDbContext : DbContext
    {
          public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    }
}