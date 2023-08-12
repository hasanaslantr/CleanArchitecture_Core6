using NLayer.Core.Abstarct;

namespace NLayer.Core.Concrete
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

    }
}
