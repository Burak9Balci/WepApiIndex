using Microsoft.AspNetCore.Identity;
using WepApiIndex.Models.Entities.Enums;
using WepApiIndex.Models.Entities.Interfaces;

namespace WepApiIndex.Models.Entities.DomainEnties
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        // RS
        public virtual UserRole UserRole { get; set; }
    }
}
