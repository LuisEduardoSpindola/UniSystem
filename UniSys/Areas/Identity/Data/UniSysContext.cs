using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;
using UniSys.Models;

namespace UniSys.Areas.Identity.Data;

public class UniSysContext : IdentityDbContext<Account>
{
    public UniSysContext(DbContextOptions<UniSysContext> options)
        : base(options)
    {
    }


    public DbSet<Course> Courses { get; set; }
    public DbSet<Suplie> Suplie { get; set; }
    public DbSet<Exercise> Exercise { get; set; }
    public DbSet<Information> Information { get; set; }
    public DbSet<Account> Accounts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
