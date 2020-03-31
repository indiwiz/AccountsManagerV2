using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AccountsManager.Infrastructure.Data
{
    public class AccountManagerDbContextFactory: IDesignTimeDbContextFactory<AccountManagerDbContext>
    {
        public AccountManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AccountManagerDbContext>();
            optionsBuilder.UseSqlite("Data Source=AccManDb.db");

            return new AccountManagerDbContext(optionsBuilder.Options);
        }
    }
}