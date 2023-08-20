using NLayer.Core.Concrete; 
using NLayer.Core.GenericRepositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository.Repositories;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class AppRoleSerivice : Service<AppRole>, IAppRoleService
    {
        public AppRoleSerivice(GenericRepositoy<AppRole> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
