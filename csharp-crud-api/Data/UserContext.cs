using Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  public class UserContext(DbContextOptions<UserContext> options) : DbContext(options)
  {
        public DbSet<User> Users { get; set; }
  }
}