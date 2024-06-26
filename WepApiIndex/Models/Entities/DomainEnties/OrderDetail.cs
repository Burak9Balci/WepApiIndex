namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class OrderDetail : BaseEntity
    {
        public int BookID { get; set; }
        public int OrderID { get; set; }
        // rs
        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}
