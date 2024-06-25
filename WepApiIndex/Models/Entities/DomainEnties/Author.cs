namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }

        //RS
        public virtual List<Book> Books { get; set; }
    }
}
