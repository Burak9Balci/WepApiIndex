using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x =>x.ID);
            builder.HasMany(x =>x.UserRoles).WithOne(x =>x.User).HasForeignKey(x => x.UserId);
        }
    }
}
