using MaktabBank.Core.Core.Entites;
using Microsoft.EntityFrameworkCore;

namespace MaktabBank.Infrastructure.EfCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}
