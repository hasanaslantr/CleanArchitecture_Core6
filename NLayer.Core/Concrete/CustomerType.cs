using NLayer.Core.Abstarct;

namespace NLayer.Core.Concrete
{
    public class CustomerType : BaseEntity
    {
        public string Name { get; set; }
        public List<Customer> Customers { get; set;}
    }
}
