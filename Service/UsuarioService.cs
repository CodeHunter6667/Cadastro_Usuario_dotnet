using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuarioApi.Dtos;
using UsuarioApi.Entities;

namespace UsuarioApi.Service
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public UsuarioService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task CadastraUsuario(UsuarioDto dto)
        {
            var usuario = _mapper.Map<Usuario>(dto);
            var resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if(!resultado.Succeeded) { throw new ApplicationException("Falha ao cadastrar usuario"); }
        }
    }
}
