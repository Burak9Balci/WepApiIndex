using Microsoft.AspNetCore.Identity;
using WepApiIndex.Models.Entities.Enums;
using WepApiIndex.Models.Entities.Interfaces;

namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class UserRole : IdentityUserRole<int>, IEntity
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public UserRole()
        {
            Status = DataStatus.Inserted;
            CreatedDate = DateTime.Now;
        }
        // RS
        public virtual AppRole Role { get; set; }
        public virtual AppUser User { get; set; }
    }
}
