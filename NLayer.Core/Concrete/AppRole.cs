using Microsoft.AspNetCore.Identity;

namespace NLayer.Core.Concrete
{
    public class AppRole : IdentityRole
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public Boolean Status { get; set; }

        public List<RoleUser> Users { get; set; }
    }
}
