using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.Configurations
{
    public class EditorConfiguration : BaseConfiguration<Editor>
    {
        public override void Configure(EntityTypeBuilder<Editor> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Books).WithOne(x => x.Editor).HasForeignKey(x => x.EditorID);
        }
    }
}
