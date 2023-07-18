using AutoMapper;
 
using UsuarioApi.Models;
using UsuariosApi.Data.Dtos;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile : Profile 
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
