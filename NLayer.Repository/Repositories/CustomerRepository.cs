using Microsoft.EntityFrameworkCore;
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
    public class CustomerRepository : GenericRepositoy<Customer>, ICustomerRepositories
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Customer>> ListTogether()
        {
            return await _context.Customers
                .Include(x => x.CustomerType).ToListAsync();
        }
    }
}
