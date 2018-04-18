using AutoMapper;
using Lgm.Emos.Infrastructure.Identity;

namespace Lgm.Emos.Web
{
    public class ApiModelToEntityMappingProfile : Profile
    {
        public ApiModelToEntityMappingProfile()
        {
            CreateMap<RegistrationApiModel, IdentityAppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
