using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Application.Models.AdicionarUsuario;
using WoMakersCode.Biblioteca.Application.UseCases;

namespace WoMakersCode.Biblioteca.API.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse> _useCaseAsync;
        public UsuariosController(IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse> useCaseAsync)
        {
            _useCaseAsync = useCaseAsync;
        }

        //[HttpGet]
        //public string Get()
        //{
        //    return "Novo Usuário";
        //}

        [HttpPost]
        public async Task<ActionResult<AdicionarUsuarioResponse>> Post([FromBody] AdicionarUsuarioRequest request)
        {
            return await _useCaseAsync.ExecuteAsync(request);
        }
        //ActionResult é um tipo dentro do .NET que encapsula os retornos, tipo o OkObjectResult
    }
}
