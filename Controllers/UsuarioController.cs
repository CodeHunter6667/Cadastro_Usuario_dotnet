using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsuarioApi.Dtos;
using UsuarioApi.Entities;
using UsuarioApi.Service;

namespace UsuarioApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> cadastaUsuario(UsuarioDto dto)
        {
            await _service.CadastraUsuario(dto);
            return Ok("Usuario Cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            var token =  await _service.Login(dto);
            return Ok(token);
        }
    }
}
