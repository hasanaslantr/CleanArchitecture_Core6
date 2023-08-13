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
    public class AppUserRepository : GenericRepositoy<AppUser>, IAppUserRepository
    {
        public AppUserRepository(AppDbContext context) : base(context)
        {
        }

        public Task<List<AppUser>> ListTogether()
        {
            throw new NotImplementedException();
        }
    }
}
