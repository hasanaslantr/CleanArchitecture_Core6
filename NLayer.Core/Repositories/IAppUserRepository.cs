using NLayer.Core.Concrete;
using NLayer.Core.GenericRepositories;

namespace NLayer.Core.Repositories
{
    public interface IAppUserRepository : IGenericrepository<AppUser>
    {
        Task<List<AppUser>> ListTogether();
    }
}
