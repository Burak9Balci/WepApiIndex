using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.Configurations
{
    public class AuthorConfiguration : BaseConfiguration<Author>
    {
        public override void Configure(EntityTypeBuilder<Author> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Books).WithOne(x => x.Author).HasForeignKey(x => x.AuthorID);
        }
    }
}
