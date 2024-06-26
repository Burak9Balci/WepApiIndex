using Microsoft.EntityFrameworkCore;
using WepApiIndex.Models.Entities.DomainEnties;

namespace WepApiIndex.Extentions
{
    public static class BookDataSeedExtentions 
    {
        public static void BookSeed(ModelBuilder builder)
        {
            Book b = new Book
            {
                ID = 1,
                Name = "Ateş ve Kan",
            };
            builder.Entity<Book>().HasData(b);
        }
    }
}
