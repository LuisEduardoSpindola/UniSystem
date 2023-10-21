using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using UniSys.Areas.Identity.Data;

public class AccountEntityConfiguration : IEntityTypeConfiguration<Account>
{
    void IEntityTypeConfiguration<Account>.Configure(EntityTypeBuilder<Account> builder)
    {
        builder.Property(b => b.Name);
        builder.Property(b => b.ImagePath);
        builder.Property(b => b.Registration);
        builder.Property(b => b.Course);
        builder.Property(b => b.Period);

    }
}