using AutoMapper; 
using NLayer.Core.Concrete;
using NLayer.Core.DTOs.AccountDtos; 
using static System.Formats.Asn1.AsnWriter;
using System.Security.Claims;

namespace NLayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AppUser, AppUserDto>().ReverseMap(); 
        }
    }
}
