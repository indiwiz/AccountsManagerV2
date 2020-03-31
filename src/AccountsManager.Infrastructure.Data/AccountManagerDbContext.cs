using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace AccountsManager.Infrastructure.Data
{
     public class AccountManagerDbContext : IdentityDbContext
    {
        public AccountManagerDbContext (
            DbContextOptions<AccountManagerDbContext> options)
            : base(options)
        {
        }
    }
}
