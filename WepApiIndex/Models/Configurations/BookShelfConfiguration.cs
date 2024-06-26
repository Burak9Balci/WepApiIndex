using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.Configurations
{
    public class BookShelfConfiguration : BaseConfiguration<BookShelf>
    {
        public override void Configure(EntityTypeBuilder<BookShelf> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Books).WithOne(x => x.BookShelf).HasForeignKey(x =>x.BookShelfID);
        }
    }
}
