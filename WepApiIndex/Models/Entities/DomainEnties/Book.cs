using System.ComponentModel;

namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int? PageNumber { get; set; }
        public int? AuthorID { get; set; }
        public int? EditorID { get; set; }
        public int? CategoryID { get; set; }
        public int? BookShelfID { get; set; }
        //RS
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual Editor Editor { get; set; }
        public virtual BookShelf BookShelf { get; set; }
    }
}
