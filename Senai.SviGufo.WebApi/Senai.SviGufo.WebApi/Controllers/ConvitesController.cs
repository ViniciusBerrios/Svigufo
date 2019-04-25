using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.SviGufo.WebApi.Interfaces;
using Senai.SviGufo.WebApi.Repositories;

namespace Senai.SviGufo.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConvitesController : ControllerBase
    {
        private IConviteRepository ConviteRepository {get; set;}

        public ConvitesController()
        {
            ConviteRepository = new ConviteRepository();
        }

        /// <summary>
        /// Somente os ADMS terão acesso a todos os convites
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(ConviteRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Deu ruim" });
            }
        }

        [Authorize]
        [HttpGet]
        [Route("meus")]
        public IActionResult MeusConvites()
        {
            try
            {
                // aonde estão as informações do usuário
                int usuarioId = Convert.ToInt32(HttpContext.User.Claims.First
                    (c => c.Type == JwtRegisteredClaimNames.Jti).Value); 
                return Ok(ConviteRepository.ListarMeusConvites(usuarioId));
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Ruim" });
            }
        }

        [Authorize]
        
        [HttpPost("inscricao/{eventoId}")]
        public IActionResult Inscricao()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}