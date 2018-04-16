using AutoMapper;
using Lgm.Emos.Infrastructure.Identity;

namespace Lgm.Emos.Web
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, IdentityAppUser>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
