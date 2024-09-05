using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace moduloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("ObterDataHora")]
      public IActionResult ObterDataHora()
      {
        var obj = new 
        {
            Data = DateTime.Now.ToLongDateString(),
            Hora = DateTime.Now.ToShortTimeString()
        };

        return Ok(obj);
      }  

        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem-vindo ao sistema!";
            return Ok(new { mensagem });
        }
            
    }
}