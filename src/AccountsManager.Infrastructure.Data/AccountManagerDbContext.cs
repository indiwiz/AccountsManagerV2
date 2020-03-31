using Microsoft.EntityFrameworkCore;

namespace AccountsManager.Infrastructure.Data
{
     public class AccountManagerDbContext : DbContext
    {
        public AccountManagerDbContext (
            DbContextOptions<AccountManagerDbContext> options)
            : base(options)
        {
        }
    }
}
