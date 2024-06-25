using WepApiIndex.Models.Entities.Enums;
using WepApiIndex.Models.Entities.Interfaces;

namespace WepApiIndex.Models.Entities.DomainEnties
{
    public abstract class BaseEntity : IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    }
}
