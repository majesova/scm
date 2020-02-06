using AutoMapper;
using CargaDescarga;
using Scm.Controllers.Dtos;
using Scm.Domain;

namespace Scm.Infrastructure.Mapping
{
    public class MappingProfile : Profile {
    public MappingProfile() {
             
             CreateMap<AppUser, RegisterUserResponseDto>().ReverseMap();

                CreateMap<ValeDto, Vale>()
                .ForMember(dest=> dest.FechaExpedicionVale, 
                          opt=>opt.MapFrom(src=>src.Fecha))
                .ForMember(dest=> dest.FolioVale, 
                         opt=>opt.MapFrom(src=>src.Folio));

                CreateMap<RegisterValesDto, RegistroVale>().ReverseMap();

                CreateMap<RegistroVale, RegisterValesResponseDto>();

        }
    }
}