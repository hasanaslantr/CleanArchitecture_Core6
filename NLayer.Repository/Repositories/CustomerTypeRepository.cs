using NLayer.Core.Concrete;
using NLayer.Core.Repositories;
using NLayer.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class CustomerTypeRepository : GenericRepositoy<CustomerType>, ICustomerTypeREpositories
    {
        public CustomerTypeRepository(AppDbContext context) : base(context)
        {
        }
    }
}
