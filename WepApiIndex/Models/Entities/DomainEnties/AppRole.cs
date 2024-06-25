using Microsoft.AspNetCore.Identity;
using WepApiIndex.Models.Entities.Enums;
using WepApiIndex.Models.Entities.Interfaces;

namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class AppRole : IdentityRole<int>, IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public AppRole()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        //RS
        public virtual UserRole UserRole { get; set; }
    }
}
