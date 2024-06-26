using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WepApiIndex.Extentions;
using WepApiIndex.Models.Configurations;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Models.ContextClass
{
    public class MyContext : IdentityDbContext<AppUser,AppRole,int,IdentityUserClaim<int>,UserRole,IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions options)  : base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            BookDataSeedExtentions.BookSeed(builder);
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new BookShelfConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new EditorConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookShelf> BookShelves { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
