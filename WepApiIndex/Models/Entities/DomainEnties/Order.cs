namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class Order : BaseEntity
    {
        public string OrderAdress { get; set; }
        public int AppUserID { get; set; }
        //RS
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
