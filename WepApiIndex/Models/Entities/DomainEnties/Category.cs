namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //RS
        public virtual List<Book> Books { get; set; }
    }
}
