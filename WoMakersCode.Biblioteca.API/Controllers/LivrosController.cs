using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoMakersCode.Biblioteca.API.Controllers
{
    [ApiController]
    [Route("[api/livros]")]
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Novo Livro";
        }

        [HttpPost]
        public string GetTeste([FromHeader] string header)
        {
            return header;
        }
    }
}
