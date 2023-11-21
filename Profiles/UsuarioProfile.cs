using AutoMapper;
using UsuarioApi.Dtos;
using UsuarioApi.Entities;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
        }
    }
}
