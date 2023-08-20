using NLayer.Core.Concrete;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository.Repositories;
using NLayer.Service.GenericManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class CustomerTypeService : Service<CustomerType>, ICustomerTypeService
    {
        public CustomerTypeService(GenericRepositoy<CustomerType> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
