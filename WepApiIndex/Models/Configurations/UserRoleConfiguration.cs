using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.Configurations
{
    public class UserRoleConfiguration : BaseConfiguration<UserRole>
    {
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            base.Configure(builder);
            builder.Ignore(x =>x.ID);
            builder.HasKey(x => new
            {
                x.RoleId,
                x.UserId
            });
        }
    }
}
