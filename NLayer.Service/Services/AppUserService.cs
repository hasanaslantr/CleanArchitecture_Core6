using AutoMapper;
 using NLayer.Core.Concrete;
using NLayer.Core.DTOs.AccountDtos;
using NLayer.Core.GenericRepositories;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Repository.Repositories;
using NLayer.Service.GenericManager;

namespace NLayer.Service.Services
{
    public class AppUserService : Service<AppUser>, IAppUserService
    {
        private readonly IAppUserRepository _appUserrepository;
        private readonly IMapper _mapper;

        public AppUserService(GenericRepositoy<AppUser> repository, IUnitOfWork unitOfWork, IAppUserRepository appUserrepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _appUserrepository = appUserrepository;
            _mapper = mapper;
        }

        public async Task<List<AppUserDto>> ListTogether()
        {
            var values = await _appUserrepository.ListTogether();
            var valuesDto = _mapper.Map<List<AppUserDto>>(values);
            return valuesDto;
        }
    }
}
