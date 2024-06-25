namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class Editor : BaseEntity
    {
        public string EditorName { get; set; }
        //RS
        public virtual List<Book> Books { get; set; }
    }
}
