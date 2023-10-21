using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;

namespace UniSys.Areas.Identity.Data;

public class UniSysContext : IdentityDbContext<Account>
{
    public UniSysContext(DbContextOptions<UniSysContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
