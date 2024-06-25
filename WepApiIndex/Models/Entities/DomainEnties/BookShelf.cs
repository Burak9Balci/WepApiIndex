namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class BookShelf : BaseEntity
    {
        public string ShelfName { get; set; }
        //RS
        public virtual List<Book> Books { get; set; }
    }
}
